
namespace Act14_Paginacion
{
  public class Frame
  {
    public int Id { get; set; }
    public int ProcessId { get; set; }
    public States State { get; set; }

    public Frame()
    {
      Id = 0;
      ProcessId = 0;
      State = States.New;
    }

    public Frame(int Id)
    {
      this.Id = Id;
      State = States.New;
    }

    public bool Equals(Frame other)
    {
      return Id == other.Id;
    }
  }
}
