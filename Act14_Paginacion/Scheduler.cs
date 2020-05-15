using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Act14_Paginacion
{
  public enum States
  {
    New,
    Ready,
    Running,
    Blocked,
    Terminated
  }

  public class Scheduler
  {
    public int GlobalTime { get; set; }
    private int totalProcesses { get; set; }

    private Memory memory;

    private int quantum;

    public Queue<Process> New { get; set; }
    public Queue<Process> Ready { get; set; }
    public Process Running { get; set; }
    public Queue<Process> Blocked { get; set; }
    public Queue<Process> Exit { get; set; }

    private static readonly Random r = new Random();

    private bool wasInterru;
    private bool wasBlocked;

    private MainWindow mW;

    public Scheduler(MainWindow mW)
    {
      New = new Queue<Process>();
      Ready = new Queue<Process>();
      Running = new Process();
      Blocked = new Queue<Process>();
      Exit = new Queue<Process>();

      this.mW = mW;
    }

    public async Task StartProcessing()
    {
      Admit();
      while(Ready.Count > 0 || Blocked.Count > 0) {
        Admit();
        Dispatch();

        await ExecuteRunning().ConfigureAwait(true);

        if(!wasBlocked && Running.State == States.Running) {
          Terminate();
        }
        wasInterru = false;
        wasBlocked = false;

      }
      //mW.UpdateLabels(new Process());
    }

    public void Admit()
    {
      while(memory.InsertProcess(New.Peek())) {
        Process p = New.Dequeue();
        p.tEsp = 0;
        p.tTra = 0;
        p.tLle = GlobalTime;
        p.State = States.Ready;
        Ready.Enqueue(p);
        //mW.tblReady.Items.Add(p);
      }
    }

    public void Dispatch()
    {
      if(Ready.Count > 0) {
        Running = Ready.Dequeue();
        Running.State = States.Running;

        //if(Running.tResp == -1)
        //  Running.tResp = GlobalTime - Running.tLle;

        //mW.tblReady.Items.Remove(Running);
      } else {
        Running = new Process();
        //mW.UpdateLabels(Running);
      }
    }

    public void Interrupt()
    {
      Running.State = States.Blocked;
      Blocked.Enqueue(Running);
    }

    public void Deinterrupt()
    {
      var p = Blocked.Dequeue();
      p.State = States.Ready;
      Ready.Enqueue(p);
    }

    public void Terminate()
    {
      if(wasInterru == false && Running.tTra < Running.TME) {
        //mW.tblReady.Items.Add(Running);
        Ready.Enqueue(Running);
      } else {
        Running.tFin = GlobalTime;
        Running.tRet = Running.tEsp + Running.tTra;
        Running.State = States.Terminated;
        Exit.Enqueue(Running);
        // --------- WINDOW ----------- //
        //mW.tblTerminated.Items.Add(Running);
      }
    }

    private async Task ExecuteRunning()
    {
      if(Running.State == States.Running) {
        int elapsed = 0;
        while(elapsed++ < quantum && Running.tTra++ < Running.TME) {
          Running.tRest = Running.TME - Running.tTra;
          IncreaseTime();

          //mW.UpdateLabels(Running);
          //mW.UpdateTable(Blocked, mW.tblBlocked);

          await Task.Delay(1000).ConfigureAwait(true);
          await WasKeyPressed().ConfigureAwait(true);

          if(wasBlocked || wasInterru) return;
        }
      } else {
        IncreaseTime();

        await Task.Delay(1000).ConfigureAwait(true);
        await WasKeyPressed().ConfigureAwait(true);

        //mW.UpdateTable(Blocked, mW.tblBlocked);
      }
    }

    private void IncreaseTime()
    {
      GlobalTime++;

      foreach(Process p in Ready)
        p.tEsp++;

      bool DeInterrupt = false;
      foreach(Process p in Blocked) {
        p.tEsp++;
        p.tBloRes = 8 - p.tBlo++;
        if(p.tBlo >= 8) {
          DeInterrupt = true;
          p.tBlo = 0;
        }
      }
      if(DeInterrupt) {
        //mW.tblBlocked.Items.Remove(Blocked.Peek());
        //mW.tblReady.Items.Add(Blocked.Peek());
        Deinterrupt();
      }
    }

    public void CreateProcesses(int totalProcesses, int quantum)
    {
      this.totalProcesses = totalProcesses;
      this.quantum = quantum;

      for(int id = 1; id <= totalProcesses; id++) {
        CreateProcess(id);
      }
    }

    private void CreateProcess(int Id)
    {
      int TME = r.Next(8, 18);
      int num1 = r.Next(0, 100);
      int opeIdx = r.Next(0, 5);
      int num2 = r.Next(0, 100);
      int size = r.Next(6, 35);

      if(opeIdx == 3 || opeIdx == 4) { num2++; }
      var Ope = new Operation(num1, opeIdx, num2);
      New.Enqueue(new Process(Id, TME, Ope, size, States.New));
    }

    private async Task WasKeyPressed()
    {
      switch(mW.KeyPressed) {
        case "I":
          wasBlocked = true;
          Interrupt();
          break;
        case "E":
          Running.Result = "ERROR";
          wasInterru = true;
          break;
        case "P":
          while(mW.KeyPressed != "C") {
            await Task.Delay(1000).ConfigureAwait(true);
          }
          break;
        case "B":
          //var myBCP = new BCP(this);
          //myBCP.ShowDialog();
          break;
        case "N":
          CreateProcess(++totalProcesses);
          Admit();
          break;
      }
      mW.KeyPressed = "";
    }
  }
}
