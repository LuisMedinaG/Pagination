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

    public Memory memory { get; set; }

    public int quantum { get; set; }

    public Queue<Process> New { get; set; }
    public Queue<Process> Ready { get; set; }
    public Process Running { get; set; }
    public Queue<Process> Blocked { get; set; }
    public Queue<Process> Exit { get; set; }

    private static readonly Random r = new Random();

    private bool wasInterru;
    private bool wasBlocked;

    private MainWindow mW;
    public int qCount;

    public Scheduler(MainWindow mW)
    {
      memory = new Memory();

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

        mW.UpdateMemory(this);
        mW.UpdateLabels(Running);

        await ExecuteRunning().ConfigureAwait(true);

        if(!wasBlocked && Running.State == States.Running) {
          Terminate();
        }
        wasInterru = false;
        wasBlocked = false;
      }
      mW.UpdateLabels(new Process());
      mW.UpdateMemory(this);
    }

    public void Admit()
    {
      while(New.Count > 0 && memory.FreeFrames > 0 && New.Peek().TotalPages <= memory.FreeFrames) {
        Process p = New.Dequeue();

        p.tEsp = 0;
        p.tTra = 0;
        p.tLle = GlobalTime;
        p.State = States.Ready;

        Ready.Enqueue(p);
        memory.InsertProcess(p, States.Ready);

        mW.tblReady.Rows.Add(p.Id, p.TME, p.tRst);
      }
    }

    public void Dispatch()
    {
      if(Ready.Count > 0) {
        Running = Ready.Dequeue();
        Running.State = States.Running;

        memory.ChangeFramesState(Running, States.Running); // <<

        if(Running.tRsp == -1)
          Running.tRsp = GlobalTime - Running.tLle;

        mW.tblReady.Rows.RemoveAt(0);
      } else {
        Running = new Process();
      }
    }

    public void Interrupt()
    {
      Running.State = States.Blocked;

      Blocked.Enqueue(Running);
      memory.ChangeFramesState(Running, States.Blocked); // <<
    }

    public void Deinterrupt()
    {
      var p = Blocked.Dequeue();
      p.State = States.Ready;

      Ready.Enqueue(p);
      memory.ChangeFramesState(p, States.Ready); // <<
    }

    public void Terminate()
    {
      if(wasInterru == false && Running.tTra < Running.TME) {
        Ready.Enqueue(Running);
        memory.ChangeFramesState(Running, States.Ready); // <<

        mW.tblReady.Rows.Add(Running.Id, Running.TME, Running.tRst);
      } else {
        Running.tFin = GlobalTime;
        Running.tRet = Running.tEsp + Running.tTra;
        Running.State = States.Terminated;
        Exit.Enqueue(Running);

        memory.FreeFrames += Running.TotalPages;
        memory.ChangeFramesState(Running, States.New); // <<

        // --------- WINDOW ----------- //
        mW.tblTerminated.Rows.Add(Running.Id, Running.Ope.ToString(), Running.Ope.Result);
      }
    }

    private async Task ExecuteRunning()
    {
      if(Running.State == States.Running) {
        qCount = 0;
        while(qCount++ < quantum && Running.tTra++ < Running.TME) {
          Running.tRst = Running.TME - Running.tTra;
          IncreaseTime();

          mW.UpdateLabels(Running);
          mW.UpdateTable(Blocked, mW.tblBlocked);

          await Task.Delay(1000).ConfigureAwait(true);
          await WasKeyPressed().ConfigureAwait(true);

          if(wasBlocked || wasInterru) return;
        }
      } else {
        IncreaseTime();

        await Task.Delay(1000).ConfigureAwait(true);
        await WasKeyPressed().ConfigureAwait(true);

        mW.UpdateTable(Blocked, mW.tblBlocked);
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
        p.tBlR = 8 - p.tBlo++;
        if(p.tBlo >= 8) {
          DeInterrupt = true;
          p.tBlo = 0;
        }
      }

      if(DeInterrupt) {
        var topBlo = Blocked.Peek();
        mW.tblBlocked.Rows.RemoveAt(0);
        mW.tblReady.Rows.Add(topBlo.Id, topBlo.TME, topBlo.tRst);
        Deinterrupt();
      }
    }

    public void CreateProcesses(int totalProcesses, int quantum)
    {
      this.totalProcesses = totalProcesses;
      this.quantum = quantum;

      for(int id = 1; id <= totalProcesses; id++) {
        New.Enqueue(CreateProcess(id));
      }
    }

    private Process CreateProcess(int Id)
    {
      int TME = r.Next(8, 18);
      int num1 = r.Next(0, 100);
      int opeIdx = r.Next(0, 5);
      int num2 = r.Next(0, 100);
      int size = r.Next(6, 35);
      if(opeIdx == 3 || opeIdx == 4) num2++;
      var Ope = new Operation(num1, opeIdx, num2);
      return new Process(Id, TME, Ope, size, States.New);
    }

    private async Task WasKeyPressed()
    {
      switch(mW.KeyPressed) {
        case "I":
          wasBlocked = true;
          Interrupt();
          break;
        case "E":
          Running.Ope.Result = "ERROR";
          wasInterru = true;
          break;
        case "P":
          while(mW.KeyPressed != "C") {
            await Task.Delay(1000).ConfigureAwait(true);
          }
          break;
        case "B":
          var myBCP = new BCP(this);
          myBCP.ShowDialog();
          break;
        case "N":
          New.Enqueue(CreateProcess(++totalProcesses));
          Admit();
          mW.UpdateMemory(this);
          break;
        default:
          break;
      }
      mW.KeyPressed = "";
    }
  }
}
