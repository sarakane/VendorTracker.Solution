namespace VendorTracker.Models
{
  public class Order
  { 
    public string OrderTitle { get; }
    public string Description { get; }
    public int Price { get; } 
    public string Date { get; }

    public Order(string orderTitle, string description, int price, string date)
    {
      OrderTitle = orderTitle;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}