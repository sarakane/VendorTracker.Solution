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
      Description = description;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Orders = new List<Order> {new Order("test", "test", 1, "test")};
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }
  }
}