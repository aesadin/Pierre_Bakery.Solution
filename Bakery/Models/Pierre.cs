using System;
using System.Linq;


namespace PierreBakery.Models
{
  public class OrderPierreBread
  {
    public string NumberLoaves {get; set;}

    public OrderPierreBread(string numberLoaves)
    {
      NumberLoaves = numberLoaves;
    }
  }

    public class OrderPierrePastry
  {
    public string NumberPastry {get; set;}
  }
}
