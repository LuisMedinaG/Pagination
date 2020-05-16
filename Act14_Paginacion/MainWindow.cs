using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;

namespace Act14_Paginacion
{
  public partial class MainWindow : Form
  {
    internal Scheduler schedule;
    internal string KeyPressed;

    public MainWindow()
    {
      InitializeComponent();

      tblMemory.Rows.Add(9);
    }

    private async void bttnStart_Click(object sender, EventArgs e)
    {
      int totalProcesses = (int)txtBoxTotalProc.Value;
      int quantum = (int)txtBoxQuantum.Value;

      if(totalProcesses > 0 && quantum > 0) {
        ClearWindow();
        EnableFields(false);
        // ---------- SCHEDULER ---------- //
        schedule = new Scheduler(this);
        schedule.CreateProcesses(totalProcesses, quantum);
        await schedule.StartProcessing();
        // ------------------------------- //
        EnableFields(true);
      }
    }

    internal async void UpdateLabels(Process p)
    {
      lblNumPro.Text = p.Id.ToString();
      lblTME_PE.Text = p.TME.ToString();
      lblOpe_PE.Text = p.Ope.ToString();
      lblTieTra.Text = p.tTra.ToString();
      lblTieRes.Text = p.tRest.ToString();

      var qNew = schedule.New;
      lblProRes.Text = qNew.Count.ToString();
      if(schedule.New.Count > 0) {
        var newTop = qNew.Peek();
        lblNextPro.Text = newTop.Id.ToString() + " " + newTop.TotalPages.ToString();
      } else {
        lblNextPro.Text = "";
      }
      lblGloTime.Text = schedule.GlobalTime.ToString();
      lblQuantum.Text = schedule.qCount.ToString();
    }

    internal void UpdateTable(Queue<Process> collection, DataGridView table)
    {
      table.Rows.Clear();
      foreach(Process p in collection) {
        if(p.State == States.Ready) {
          table.Rows.Add(p.Id, p.TME, p.tTra);
        } else if(p.State == States.Blocked) {
          table.Rows.Add(p.Id, p.TME, p.tBloRes);
        } else if(p.State == States.Terminated) {
          table.Rows.Add(p.Id, p.Ope.ToString(), p.Ope.Result);
        }
      }
    }

    private void EnableFields(bool state)
    {
      txtBoxTotalProc.Enabled = state;
      txtBoxQuantum.Enabled = state;
      bttnStart.Enabled = state;
    }

    private void ClearWindow()
    {
      tblTerminated.Rows.Clear();
      tblBlocked.Rows.Clear();
      tblReady.Rows.Clear();

      lblNumPro.Text = "";
      lblTME_PE.Text = "";
      lblOpe_PE.Text = "";
      lblTieTra.Text = "";
      lblTieRes.Text = "";
    }

    internal void UpdateMemory(Scheduler scheduler)
    {
      var frames = scheduler.memory.Frames;
      for(int i = 0, fId = 0; i < 9; i++) {
        for(int j = 0; j < 5; j++) {
          var frame = frames[fId];
          var cell = tblMemory.Rows[i].Cells[j];
          cell.Value = (fId + 1) + Environment.NewLine + frame.ProcessId;
          cell.Style.BackColor = StateColor(frame.State);
          fId++;
        }
      }
    }

    private Color StateColor(States state)
    {
      Color c = Color.White;
      switch(state) {
        case States.New:
          c = Color.White;
          break;
        case States.Ready:
          c = Color.Orange;
          break;
        case States.Running:
          c = Color.Red;
          break;
        case States.Blocked:
          c = Color.LightGoldenrodYellow;
          break;
        case States.Terminated:
          c = Color.Gray;
          break;
        default:
          break;
      }
      return c;
    }

    private void TeclaPresionada(object sender, KeyEventArgs e)
    {
      KeyPressed = e.KeyCode.ToString();
    }
  }
}
