using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.TestTools
{
  [TestClass]
  public class OrderTest
  {
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
  }
}