using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("/About")]
    public IActionResult About()
    {
      return View();
    }

    [HttpGet("/Contact")]
    public IActionResult Contact()
    {
      return View();
    }
  }
}
