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
      TotalBreadCost = 5 * NumberLoaves;
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
      if (NumberLoaves > 2)
      {
        TotalBreadCost -= ((NumberLoaves/3)*5);
      }
      return TotalBreadCost; 
    }
  }
}
