using System;
using PierreBakery.Models;
using System.Collections.Generic;


namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread costs $5 a loaf or 3 loaves for $10 and Pastries cost $2 or 3 for $5");
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("How many loaves of Bread would you like?");
      BreadOrder newBreadOrder = new BreadOrder(int.Parse(Console.ReadLine()));

      if (newBreadOrder.IsOnlyPositiveNumberCharacters())
      {
        Console.WriteLine("Here is your bread order total: $" + (newBreadOrder.GetBreadTotal()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number");
        Start();
      }

      Console.WriteLine("How many pastries would you like?");
      PastryOrder newPastryOrder = new PastryOrder(int.Parse(Console.ReadLine()));

      if (newPastryOrder.IsOnlyPositiveNumberCharacters2())
      {
        Console.WriteLine("Here is your pastry order total: $" + (newPastryOrder.GetPastryTotal()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number");
        Start();
      }

      Console.WriteLine("Here is your grand total: $" + (newBreadOrder.GetBreadTotal() + newPastryOrder.GetPastryTotal()));
    }
  }
}