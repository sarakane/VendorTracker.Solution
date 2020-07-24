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
      Order newOrder = new Order("croissants", "weekly", 35,"7/24/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}