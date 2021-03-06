using System;

namespace PierreBakery.Models
{
  public class BreadOrder
  {
    public int NumberLoaves {get; set;}
    public int TotalBreadCost {get; set;}

    public BreadOrder(int numberLoaves)
    {
      NumberLoaves = numberLoaves;
      TotalBreadCost = 5;
    }

    public bool IsOnlyPositiveNumberCharacters()
    {
      if (NumberLoaves > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int GetBreadTotal()  
    {
      int newTotal = TotalBreadCost * NumberLoaves;
      if (NumberLoaves > 2)
      {
        newTotal -= ((NumberLoaves/3)*5);
      }
      return newTotal; 
    }
  }
}
