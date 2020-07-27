using System;

namespace PierreBakery.Models
{
  public class PastryOrder
  {
    public int NumberPastries {get; set;}

    public int TotalPastryCost{get; set;}

    public PastryOrder (int numberPastries)
    {
      NumberPastries = numberPastries;
      TotalPastryCost = 0;
    }

    public bool IsOnlyPositiveNumberCharacters2()
    {
      if (NumberPastries > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int GetPastryTotal()
    {
      if (NumberPastries % 3 == 0)
      {
        this.TotalPastryCost = (5 * (NumberPastries/3)) - (NumberPastries/3);
      }
      else 
      {
        this.TotalPastryCost = (NumberPastries * 2);
      }
      return this.TotalPastryCost; 
    }
  }  

}
