using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System;
using System.Collections.Generic;


namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_ConstructAnInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void IsOnlyPositiveNumberCharacters_ChecksIfInputIsIntOfNumberChars_False()
    {
      BreadOrder newBreadOrder = new BreadOrder(-1);
      Assert.AreEqual(false, newBreadOrder.IsOnlyPositiveNumberCharacters());
    }

    [TestMethod]
    public void GetBreadTotal_ReturnsBreadTotalToUser_10()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      Assert.AreEqual(5, newBreadOrder.GetBreadTotal());
    }


      [TestMethod]
    public void PastryOrderConstructor_ConstructAnInstanceOfPastryClass_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(1);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void IsOnlyPositiveNumberCharacters2_ChecksIfInputIsIntOfNumberChars_False()
    {
      PastryOrder newPastryOrder = new PastryOrder(-1);
      Assert.AreEqual(false, newPastryOrder.IsOnlyPositiveNumberCharacters2());
    }
  }
}