using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  }
}