using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  public class StudentController : Controller
  {
    private readonly IUnitOfWork unitOfWork;

    public StudentController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> StudentList()
    {
      try
      {
        Thread.Sleep(1000);
        var students = await this.unitOfWork.Students.GetAllStudentsAsync();

        return PartialView("_StudentList", students);
      }
      catch
      {
        // ToDo: Logging
        return PartialView("ErrorRetrivingData");
      }
    }

    public async Task<IActionResult> GetStudentDetails(int studentId)
    {
      try
      {
        Thread.Sleep(1000);
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        return PartialView("_StudentDetails", student);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }
  }
}