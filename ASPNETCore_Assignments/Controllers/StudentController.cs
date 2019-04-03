using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
	[Route("/SchoolManagement/[Controller]/[action]")]
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

		[Route("{studentId}")]
		public async Task<IActionResult> Details(int studentId)
    {
      try
      {
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        return View(student);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }

		public IActionResult AddStudent()
		{
			return PartialView("_AddStudent");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddStudent(StudentForCreatingDto dto)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState.Values);
				}

				await this.unitOfWork.Students.AddStudentAsync(dto);

				if (!await this.unitOfWork.SaveAsync())
				{
					return PartialView("_SavingError");
				}

				var students = await this.unitOfWork.Students.GetAllStudentsAsync();

				return PartialView("_StudentList", students);
			}
			catch
			{
				// ToDo: Logging
			}

			return PartialView("_ServerError");
		}
	}
}