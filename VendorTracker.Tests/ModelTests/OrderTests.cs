using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

namespace VendorTracker.TestTools
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1,"test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  
    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "croissants";

      Order newOrder = new Order(orderTitle, "weekly", 35,"7/24/2020");
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string orderTitle = "croissants";
      string description = "weekly";

      Order newOrder = new Order(orderTitle, description, 35,"7/24/2020");
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string orderTitle = "croissants";
      string description = "weekly";
      int price = 35;

      Order newOrder = new Order(orderTitle, description, price,"7/24/2020");
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_Int()
    {
      string orderTitle = "croissants";
      string description = "weekly";
      int price = 35;
      string date = "7/24/2020";

      Order newOrder = new Order(orderTitle, description, price,date);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetId_ItemsTenstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderTitle = "croissants";
      string description = "weekly";
      int price = 35;
      string date = "7/24/2020";

      Order newOrder = new Order(orderTitle, description, price,date);
      int result = newOrder.ID;

      Assert.AreEqual(1, result);
    }
  }
}