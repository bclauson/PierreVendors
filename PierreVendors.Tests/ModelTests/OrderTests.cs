using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendors.Models;
using System.Collections.Generic;
using System;

namespace PierreVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "test desc", 1, "1/1/1");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}