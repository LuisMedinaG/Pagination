using System.Collections.Generic;

namespace Act14_Paginacion
{
  public class Memory
  {
    public const int FRAME_SIZE = 4;
    public const int MEMORY_SIZE = 180;
    public const int TOTAL_FRAMES = MEMORY_SIZE / FRAME_SIZE;

    public int FreeFrames { get; set; }
    public List<Frame> Frames { get; set; }

    public Memory()
    {
      FreeFrames = TOTAL_FRAMES;
      Frames = new List<Frame>();

      for(int id = 1; id <= TOTAL_FRAMES; id++) {
        Frames.Add(new Frame(id));
      }

      /* Ocupy frames for the Operating system*/
      Process OS = new Process {
        Id = -1,
        TotalPages = 3
      };
      InsertProcess(OS, States.Terminated);
    }

    public void InsertProcess(Process p, States state)
    {
      int totalPages = p.TotalPages;
      foreach(Frame f in Frames) {
        if(totalPages == 0) break;
        if(f.State == States.New) {
          f.ProcessId = p.Id;
          f.State = state;
          p.Frames.Add(f);
          totalPages--;
        }
      }
      FreeFrames -= p.TotalPages;
    }

    public void ChangeFramesState(Process p, States State)
    {
      foreach(Frame pFrame in p.Frames) {
        Frame mFrame = Frames[pFrame.Id - 1];
        // Update frame state
        mFrame.State = State;
        if(p.State == States.Terminated) {
          // If state is Terminated restore process Id of frame
          mFrame.ProcessId = 0;
        }
      }
    }
  }
}
