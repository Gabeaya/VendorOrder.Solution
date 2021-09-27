using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, string price, string date)
    {
      Order myOrder = new Order(title, description, price, date);
      return RedirectToAction("Index");
    }
  }
}