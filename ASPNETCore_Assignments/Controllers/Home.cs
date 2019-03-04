using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Controllers
{
  public class Home : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    public IActionResult Contact()
    {
      return View();
    }
  }
}
