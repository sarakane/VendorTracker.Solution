using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(newVendor);
    }
  }
}