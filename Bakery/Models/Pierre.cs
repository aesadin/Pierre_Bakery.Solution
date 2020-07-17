using System;
using System.Linq;


namespace PierreBakery.Models
{
  public class OrderPierreBread
  {
    public string NumberLoaves {get; set;}
    public int TotalBreadCost {get; set;}

    public OrderPierreBread(string numberLoaves)
    {
      NumberLoaves = numberLoaves;
      TotalBreadCost = 0;
    }
  }

    public class OrderPierrePastry
  {
    public string NumberPastry {get; set;}
  }
}
