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

  }
}
