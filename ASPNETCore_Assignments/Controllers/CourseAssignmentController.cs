using ASPNETCore_Assignments.Reository.Data;
using ASPNETCore_Assignments.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Controllers
{
  [Route("/SchoolManagement/[Controller]/[action]")]
  public class CourseAssignmentController : Controller
	{
    private readonly IUnitOfWork unitOfWork;

    public CourseAssignmentController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }

    public IActionResult AddCourseAssignment()
		{
			return PartialView("_AddCourseAssignment");
		}

    public async Task<IActionResult> TeacherCourseAssignments(int courseId)
    {
      try
      {
        Thread.Sleep(1000);
        var courseAssignments = await this.unitOfWork.CourseAssignment.GetAssignmentsForCourse(courseId);
        var teacherCourseAssignmentsViewModel = new TeacherCourseAssignmentViewModel
        {
          CourseAssignments = courseAssignments,
          CourseId = courseId
        };

        return PartialView("_TeacherCourseAssignments", teacherCourseAssignmentsViewModel);
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> TeacherCourseAssignments(TeacherCourseAssignmentViewModel model)
    {
      try
      {
        Thread.Sleep(1000);
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        await this.unitOfWork.CourseAssignment.SetAssignmentsForCourseAsync(model.CourseId, model.CourseAssignments);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        return Ok(new { courseId = model.CourseId });
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }
  }
}