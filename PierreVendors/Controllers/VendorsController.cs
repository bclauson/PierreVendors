using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreVendors.Models;

namespace PierreVendors.Controllers
{
  public class VendorsController : Controller
  {


    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorsName)
    {
      Vendors newVendor = new Vendors(vendorsName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorsId}")]
    public ActionResult Show(int vendorsId)
    {
      Dictionary<string,object> model = new Dictionary<string, object>();
      Vendors selectedVendors = Vendors.Find(vendorsId);
      List<Order> vendorsOrders = selectedVendors.Orders;
      model.Add("vendors", selectedVendors);
      model.Add("orders", vendorsOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorsId}/orders")]
    public ActionResult Create(int vendorsId, string orderTitle, string orderDescription, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string,object>();
      Vendors foundVendors = Vendors.Find(vendorsId);
      Order newOrder = new Order(orderTitle, orderDescription, price, date);
      foundVendors.AddOrder(newOrder);
      List<Order> vendorsOrders = foundVendors.Orders;
      model.Add("orders", vendorsOrders);
      model.Add("vendors", foundVendors);
      return View("Show", model);

    }



  }
}