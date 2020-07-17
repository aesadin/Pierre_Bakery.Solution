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
    public string NumberPastries {get; set;}

    public int TotalPastryCost{get; set;}

    public OrderPierrePastry(string numberPastries)
    {
      NumberPastries = numberPastries;
      TotalPastryCost = 0;
    }
  }
}
