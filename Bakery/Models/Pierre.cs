using System;
using System.Linq;


namespace PierreBakery.Models
{
  public class OrderPierreBread
  {
    public int NumberLoaves {get; set;}
    public int TotalBreadCost {get; set;}

    public OrderPierreBread(int numberLoaves)
    {
      NumberLoaves = numberLoaves;
      TotalBreadCost = 0;
    }
  }

    public class OrderPierrePastry
  {
    public int NumberPastries {get; set;}

    public int TotalPastryCost{get; set;}

    public OrderPierrePastry(int numberPastries)
    {
      NumberPastries = numberPastries;
      TotalPastryCost = 0;
    }
  }
}
