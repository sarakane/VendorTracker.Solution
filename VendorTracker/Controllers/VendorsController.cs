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
      Vendor vendor = Vendor.Find(id);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, float orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      vendor.AddOrder(newOrder);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}