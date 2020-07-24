using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorInstances = new List<Vendor>{};
    public string Name { get; }
    public string Description { get; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = "";
      Id = 0;
      Orders = new List<Order> {new Order("test", "test", 1, "test")};
    }
  }
}