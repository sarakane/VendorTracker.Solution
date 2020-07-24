using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor newVendor = Vendor.Find(id);
      List<Order> vendorOrders = newVendor.Orders;
      model.Add("vendor", newVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}