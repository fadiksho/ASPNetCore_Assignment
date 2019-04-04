using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  [Route("/SchoolManagement/[Controller]/[action]")]
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
      catch
      {
        // ToDo: Logging
      }
      return PartialView("ErrorRetrivingData");
    }

    [Route("{courseId}")]
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

    public IActionResult AddCourse()
    {
      Thread.Sleep(1000);
      return PartialView("_AddCourse");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddCourse(CourseForCreatingDto dto)
    {
      try
      {
        Thread.Sleep(1000);
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        await this.unitOfWork.Courses.AddCourseAsync(dto);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        var courses = await this.unitOfWork.Courses.GetAllCoursesAsync();

        return PartialView("_CourseList", courses);
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteCourse(int courseId)
    {
      try
      {
        Thread.Sleep(1000);

        // ToDo: Check if course exist before deleting

        await this.unitOfWork.Courses.DeleteCourseAsync(courseId);

        if (!await this.unitOfWork.SaveAsync())
        {
          return BadRequest();
        }

        return NoContent();
      }
      catch
      {
        // ToDo: Logging
      }

      return StatusCode(500);
    }
  }
}