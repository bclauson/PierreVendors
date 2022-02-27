using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendors.Models;
using System.Collections.Generic;
using System;

namespace PierreVendors.Tests
{
  [TestClass]
  public class VendorsTests : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }

    [TestMethod]
    public void VendorsConstructor_CreateInstanceOfVendors_Vendors()
    {
      Vendors newVendors = new Vendors("test Vendor");
      Assert.AreEqual(typeof(Vendors), newVendors.GetType());
    }

    [TestMethod]
    public void VendorsName_GetNameOfVendor_Vendors()
    {
      
      Vendors newVendor = new Vendors("Suzie");
      Assert.AreEqual("Suzie", newVendor.Vendor);

    }

  }

}