using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  public class TeacherController : Controller
  {
    private readonly IUnitOfWork unitOfWork;

    public TeacherController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> TeacherList()
    {
      try
      {
        Thread.Sleep(1000);
        var teachers = await this.unitOfWork.Teachers.GetAllTeachersAsync();

        return PartialView("_TeacherList", teachers);
      }
      catch
      {
        // ToDo: Logging
        return PartialView("ErrorRetrivingData");
      }
    }

    public async Task<IActionResult> GetTeacherDetails(int teacherId)
    {
      try
      {
        Thread.Sleep(1000);
        var teacher = await this.unitOfWork.Teachers.GetTeacherAsync(teacherId);

        return PartialView("_TeacherDetails", teacher);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }
  }
}