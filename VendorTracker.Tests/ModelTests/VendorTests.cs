using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test";
      string description = "test";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test";
      string description = "test";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test";
      string description = "test";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("test1", "test2");
      Vendor newVendor2 = new Vendor("test2", "test2");
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("test1", "test2");
      Vendor newVendor2 = new Vendor("test2", "test2");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}