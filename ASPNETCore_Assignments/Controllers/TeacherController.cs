using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  [Route("/SchoolManagement/[Controller]/[action]")]
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

		[Route("{teacherId}")]
		public async Task<IActionResult> Details(int teacherId)
    {
      try
      {
        Thread.Sleep(1000);
        var teacher = await this.unitOfWork.Teachers.GetTeacherAsync(teacherId);

        return View(teacher);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }
		
		public IActionResult AddTeacher()
		{
			return PartialView("_AddTeacher");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddTeacher(TeacherForCreatingDto dto)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState.Values);
				}

				await this.unitOfWork.Teachers.AddTeacherAsync(dto);

				if (!await this.unitOfWork.SaveAsync())
				{
					return PartialView("_SavingError");
				}

				var teachers = await this.unitOfWork.Teachers.GetAllTeachersAsync();

				return PartialView("_TeacherList", teachers);
			}
			catch
			{
				// ToDo: Logging
			}

			return PartialView("_ServerError");
		}
	}
}