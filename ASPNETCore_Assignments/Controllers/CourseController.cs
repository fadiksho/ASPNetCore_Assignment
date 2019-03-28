using System;
using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  public class CourseController : Controller
  {
    private readonly IUnitOfWork unitOfWork;

    public CourseController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> CourseList()
    {
      try
      {
        Thread.Sleep(1000);
        var courses = await this.unitOfWork.Courses.GetAllCoursesAsync();

        return PartialView("_CourseList", courses);
      }
      catch (Exception ex)
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }

    public async Task<IActionResult> GetCourseDetails(int courseId)
    {
      try
      {
        Thread.Sleep(1000);
        var course = await this.unitOfWork.Courses.GetCourseAsync(courseId);

        return PartialView("_CourseDetails", course);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }
  }
}