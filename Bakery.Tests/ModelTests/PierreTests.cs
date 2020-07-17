using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PierreBakery.Tests
{
  [TestClass]
  public class OrderPierreBreadTests
  {
    [TestMethod]
    public void OrderPierreBreadConstructor_ConstructAnInstanceOfBreadClass_1()
    {
      OrderPierreBread testOrderPierreBread = new OrderPierreBread(1);
      Assert.AreEqual(1, testOrderPierreBread.NumberLoaves);
    }

    [TestMethod]
    public void GetBreadTotal_ReturnsTotalCostOfBreakOrder_5()
    {
      OrderPierreBread testOrderPierreBread = new OrderPierreBread(1);
      Assert.AreEqual(5, OrderPierreBread.GetBreadTotal());
    }

      [TestMethod]
    public void OrderPierrePastryConstructor_ConstructAnInstanceOfPastryClass_1()
    {
      OrderPierrePastry testOrderPierrePastry = new OrderPierrePastry(1);
      Assert.AreEqual(1, testOrderPierrePastry.NumberPastries);
    }
  }
}