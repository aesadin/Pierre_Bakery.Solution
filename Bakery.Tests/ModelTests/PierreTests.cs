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
      OrderPierreBread testOrderPierreBread = new OrderPierreBread("1");
      Assert.AreEqual("1", testOrderPierreBread.Cost);
    }
  }
}