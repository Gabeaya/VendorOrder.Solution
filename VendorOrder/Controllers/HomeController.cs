using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Pan Dulces", "25 pounds of bread","$150.00", "01/21/16");
      return View(starterOrder);
    }
  }
}