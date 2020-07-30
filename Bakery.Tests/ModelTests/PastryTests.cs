using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System;
using System.Collections.Generic;


namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryOrderTests
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
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(10, newBreadOrder.GetBreadTotal());
    }



// Pastry CLass
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

    [TestMethod]
    public void GetPastryTotal_ReturnsPastryTotalToUser_10()
    {
      PastryOrder newPastryOrder = new PastryOrder(1);
      Assert.AreEqual(2, newPastryOrder.GetPastryTotal());
    }

    [TestMethod]
    public void GetPastryTotal_ReturnsPastryTotalToUser_4()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(4, newPastryOrder.GetPastryTotal());
    }
  }
}