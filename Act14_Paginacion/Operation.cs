namespace Act14_Paginacion
{
  public class Operation
  {
    private int Const1 { get; set; }
    private int Ope { get; set; }
    private int Const2 { get; set; }

    public string Result { get; set; }

    public Operation(int Const1, int Ope, int Const2)
    {
      this.Const1 = Const1;
      this.Ope = Ope;
      this.Const2 = Const2;
      Result = Solve();
    }

    public Operation() { }

    public string Solve()
    {
      double res = 0;
      switch(Ope) {
        case 1: res = Const1 + Const2; break;
        case 2: res = Const1 - Const2; break;
        case 3: res = Const1 * Const2; break;
        case 4: res = Const1 / Const2; break;
        case 5: res = Const1 % Const2; break;
      }
      return res.ToString();
    }

    public override string ToString()
    {
      string c = "";
      switch(Ope) {
        case 1: c = "+"; break;
        case 2: c = "-"; break;
        case 3: c = "*"; break;
        case 4: c = "/"; break;
        case 5: c = "%"; break;
        default: break;
      }
      return $"{Const1} {c} {Const2}";
    }
  }
}