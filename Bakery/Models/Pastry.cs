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
      TotalPastryCost = 2;
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
      int newPastryTotal = TotalPastryCost * NumberPastries;
      if (NumberPastries > 2)
      {
        newPastryTotal -= ((NumberPastries/3) * 1);
      }
      return newPastryTotal; 
    }
  }  
}
