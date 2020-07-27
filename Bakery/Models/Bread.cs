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
      TotalBreadCost = 0;
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
      if (NumberLoaves % 3 == 0)
      {
        this.TotalBreadCost = ((NumberLoaves*5) - ((NumberLoaves/3)*5));
      }
      else
      {
        this.TotalBreadCost = (NumberLoaves * 5);
      }
      return this.TotalBreadCost; 
    }
  }
}
