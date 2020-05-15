using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act14_Paginacion
{
  public partial class BCP : Form
  {
    public BCP(Scheduler scheduler)
    {
      InitializeComponent();

      Process pCpy;
      //tblBCP.Items.Clear();
      foreach(Process p in scheduler.New) {
        //pCpy = new Process(p) {
        //  Result = " "
        //};
        //tblBCP.Items.Add(pCpy);
      }
      foreach(Process p in scheduler.Ready) {
        //pCpy = new Process(p) {
        //  Result = " "
        //};
        //tblBCP.Items.Add(pCpy);
      }
      if(scheduler.Running.State == States.Running) {
        //pCpy = new Process(scheduler.Running) {
        //  Result = " "
        //};
        //tblBCP.Items.Add(pCpy);
      }
      foreach(Process p in scheduler.Blocked) {
        //pCpy = new Process(p) {
        //  Result = " "
        //};
        //tblBCP.Items.Add(pCpy);
      }
      foreach(Process p in scheduler.Exit) {
        //tblBCP.Items.Add(p);
      }
    }
  }
}
