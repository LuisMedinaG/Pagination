using System;
using System.Collections.Generic;
using System.Linq;

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

    public int tTra { get; set; }
    public int tBlo { get; set; }
    public int tBlR { get; set; }
    public int tLle { get; set; }
    public int tFin { get; set; }
    public int tRet { get; set; }
    public int tRsp { get; set; }
    public int tEsp { get; set; }
    public int tSer { get; set; }
    public int tRst { get; set; }

    public Process()
    {
      State = States.New;
      Frames = new List<Frame>();
      Ope = new Operation();

      tRst = TME;
      tRsp = -1;
      tTra = -1;
      tBlo = -1;
      tBlR = -1;
      tLle = -1;
      tFin = -1;
      tRet = -1;
      tRsp = -1;
      tEsp = -1;
      tSer = -1;
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

      tRst = TME;
      tRsp = -1;
      tTra = -1;
      tBlo = -1;
      tBlR = -1;
      tLle = -1;
      tFin = -1;
      tRet = -1;
      tRsp = -1;
      tEsp = -1;
      tSer = -1;
    }

    public bool Equals(Process other)
    {
      return Id == other.Id;
    }

    public object[] ToStringAll()
    {
      object[] arr = {  Id.ToString(), State.ToString(), Ope.ToString(),Ope.Result,
                        tLle.ToString(), tFin.ToString(), tRet.ToString(), tRsp.ToString(),
                        tEsp.ToString(), tTra.ToString(), tRst.ToString(), tBlR.ToString() };
      return arr;
    }
  }
}
