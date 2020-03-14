using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
      [Route("/vendorOrder_photos")]
      public ActionResult VendorOrderPhotos()
      {
      return View();
      }
  }
}