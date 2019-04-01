using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
	public class CourseAssignmentController : Controller
	{
		public IActionResult AddCourseAssignment()
		{
			return PartialView("_AddCourseAssignment");
		}
	}
}