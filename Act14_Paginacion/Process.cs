using System;
using System.Collections.Generic;

namespace Act14_Paginacion
{
  public class Process : IEquatable<Process>
  {
    public int Id { get; set; }
    public int TME { get; set; }
    public double Size { get; set; }
    public States State { get; set; }
    public Operation Ope { get; set; }
    public int TotalPages { get; set; }
    public List<Frame> Frames { get; set; }
    public string Result { get; set; }

    public int tTra { get; set; }
    public int tBlo { get; set; }
    public int tBloRes { get; set; }
    public int tLle { get; set; }
    public int tFin { get; set; }
    public int tRet { get; set; }
    public int tResp { get; set; }
    public int tEsp { get; set; }
    public int tSer { get; set; }
    public int tRest { get; set; }

    public Process()
    {
      State = States.New;
      Frames = new List<Frame>();
      Ope = new Operation();
      tResp = -1;
    }

    public Process(int Id, int TME, Operation Ope, double Size, States State)
    {
      this.Id = Id;
      this.TME = TME;
      this.Ope = Ope;
      this.Size = Size;
      this.State = State;

      TotalPages = (int)Math.Ceiling(Size / 4); // 4 = FRAME_SIZE
      Frames = new List<Frame>();
      
      tRest = TME;
      tResp = -1;
    }

    public bool Equals(Process other)
    {
      return Id == other.Id;
    }
  }
}
