using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows;
//using System.Windows.Controls;

namespace Act14_Paginacion
{
  public partial class MainWindow : Form
  {
    internal Scheduler schedule;
    internal string KeyPressed;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
      //int totalProcesses = (int)txtBoxTotalProc.Value;
      //int quantum = (int)txtBoxQuantum.Value;

      //if(totalProcesses > 0 && quantum > 0) {
        //ClearWindow();
        //EnableFields(false);
        // ---------- SCHEDULER ---------- //
        //schedule = new Scheduler.Scheduler(this);
        //schedule.CreateProcesses(totalProcesses, quantum);
        //await schedule.StartProcessing();
        // ------------------------------- //
        //EnableFields(true);
      //}
    }

    internal async void UpdateLabels(Process p)
    {
      //lblNumPro.Content = p.Id;
      //lblTME_PE.Content = p.TME;
      //lblOpe_PE.Content = p.Ope;
      //lblTieTra.Content = p.tTra;
      //lblTieRes.Content = p.tRest;

      //lblProRes.Content = schedule.New.Count;
      //lblGloTime.Content = schedule.GlobalTime;
    }

    internal void UpdateTable(Queue<Process> collection, DataGrid table)
    {
      //table.Items.Clear();
      //foreach(Process p in collection) {
      //  table.Items.Add(p);
      //}
    }

    private void EnableFields(bool state)
    {
      //txtBoxTotalProc.IsEnabled = state;
      //bttnStart.IsEnabled = state;
    }

    private void ClearWindow()
    {
      //tblTerminated.Items.Clear();
      //tblBlocked.Items.Clear();
      //tblReady.Items.Clear();

      //lblNumPro.Content = "";
      //lblTME_PE.Content = "";
      //lblOpe_PE.Content = "";
      //lblTieTra.Content = "";
      //lblTieRes.Content = "";
    }

    //private void TeclaPresionada(object sender, System.Windows.Input.KeyEventArgs e)
    //{
    //  KeyPressed = e.Key.ToString();
    //}
  }
}
