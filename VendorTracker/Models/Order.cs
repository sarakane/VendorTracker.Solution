using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  { 
    private static List<Order> _orderInstances = new List<Order> {};
    public string OrderTitle { get; }
    public string Description { get; }
    public int Price { get; } 
    public string Date { get; }
    public int Id { get; }

    public Order(string orderTitle, string description, int price, string date)
    {
      OrderTitle = orderTitle;
      Description = description;
      Price = price;
      Date = date;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
    }

    public static void ClearAll()
    {
      _orderInstances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orderInstances[searchId - 1];
    }
  }
}