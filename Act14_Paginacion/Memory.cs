using System.Collections.Generic;

namespace Act14_Paginacion
{
  class Memory
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
        Size = 9.0
      };
      InsertProcess(OS);
    }

    public bool InsertProcess(Process p)
    {
      if(p.TotalPages > FreeFrames || FreeFrames == 0) return false;

      int totalPages = p.TotalPages;
      foreach(Frame f in Frames) {
        if(totalPages == 0) break;
        if(f.State == States.New) {
          f.ProcessId = p.Id;
          f.State = States.Ready;
          p.Frames.Add(f);
          totalPages--;
        }
      }

      return true;
    }

    public void ChangeFramesState(Process p, States State)
    {
      foreach(Frame pFrame in p.Frames) {
        Frame mFrame = Frames[pFrame.Id];
        // Update frame state
        mFrame.State = State;
        if(State == States.Terminated) {
          // If state is Terminated restore process Id of frame
          mFrame.ProcessId = -1;
        }
      }
    }
  }
}
