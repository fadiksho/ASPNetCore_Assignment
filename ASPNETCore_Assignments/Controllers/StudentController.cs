using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  [Route("/SchoolManagement/[Controller]/[action]")]
  public class StudentController : Controller
  {
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
    {
      this.unitOfWork = unitOfWork;
      this.mapper = mapper;
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
        Thread.Sleep(1000);
        // ToDo: Check if student exist before editing
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        return View(student);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }
    [Route("{studentId}")]
    public async Task<IActionResult> _Details(int studentId)
    {
      try
      {
        Thread.Sleep(1000);
        // ToDo: Check if student exist before editing
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        return PartialView("_StudentDetails", student);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("_ServerError");
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

    public async Task<IActionResult> Edit(int studentId)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }
        // ToDo: Check if student exist before editing
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        var studentForUpdatingDto = this.mapper.Map<StudentForUpdatingDto>(student);

        return PartialView("_Edit", studentForUpdatingDto);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int studentId, StudentForUpdatingDto dto)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }
        if (studentId != dto.Id)
        {
          return BadRequest();
        }
        // ToDo: Check if student exist before editing
        await this.unitOfWork.Students.UpdateStudentAsync(studentId, dto);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }
        var student = await this.unitOfWork.Students.GetStudentAsync(studentId);

        return PartialView("_StudentDetails", student);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteStudent(int id)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        // ToDo: Check if student exist before deleting

        await this.unitOfWork.Students.DeleteStudentAsync(id);

        if (!await this.unitOfWork.SaveAsync())
        {
          return BadRequest();
        }

        return Ok(new { id });
      }
      catch
      {
        // ToDo: Logging
      }

      return StatusCode(500);
    }
  }
}