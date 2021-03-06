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
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(10, newBreadOrder.GetBreadTotal());
    }
  }
}