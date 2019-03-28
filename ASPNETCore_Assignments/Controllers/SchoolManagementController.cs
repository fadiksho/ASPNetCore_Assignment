using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  public class SchoolManagementController : Controller
  {
    private readonly IUnitOfWork unitOfWork;

    public SchoolManagementController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> DashBoard()
    {
      try
      {
        var teachers = await this.unitOfWork.Teachers.GetAllTeachersAsync();

        return View(teachers);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }
  }
}