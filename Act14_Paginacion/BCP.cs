using System.Linq;
using System.Windows.Forms;

namespace Act14_Paginacion
{
  public partial class BCP : Form
  {
    public BCP(Scheduler scheduler)
    {
      InitializeComponent();

      foreach(Process p in scheduler.New) {
        tblBCP.Rows.Add(p.ToStringAll());
      }
      foreach(Process p in scheduler.Ready) {
        tblBCP.Rows.Add(p.ToStringAll());
      }
      if(scheduler.Running.State == States.Running) {
        tblBCP.Rows.Add(scheduler.Running.ToStringAll());
      }
      foreach(Process p in scheduler.Blocked) {
        tblBCP.Rows.Add(p.ToStringAll());
      }
      foreach(Process p in scheduler.Exit) {
        tblBCP.Rows.Add(p.ToStringAll());
      }
    }
  }
}
