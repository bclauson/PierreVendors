using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreVendors.Models;

namespace PierreVendors.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendors/{vendorsId}/order/new")]
    public ActionResult New(int vendorsId)
    {
      Vendors vendors = Vendors.Find(vendorsId);
      return View(vendors);
    }

    [HttpGet("/vendors/{vendorsId}/order/{orderId}")]
    public ActionResult Show(int vendorsId, int orderId)
    {
      Dictionary<string,object> model = new Dictionary<string, object>();
      Vendors selectedVendors = Vendors.Find(vendorsId);
      Order selectedOrder = Order.Find(orderId);
      List<Order> vendorsOrders = selectedVendors.Orders;
      model.Add("vendors", selectedVendors);
      model.Add("order", selectedOrder);
      return View(model);
    }

  }
}
