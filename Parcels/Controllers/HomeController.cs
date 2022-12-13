using Microsoft.AspNetCore.Mvc;

namespace ParcelSolution.Controllers
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