using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
