using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using ASPNETCore_Assignments.ViewModel;
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

    public async Task<IActionResult> SelectTeacherToCourse()
    {
      try
      {
        Thread.Sleep(1000);
        var teachers = await this.unitOfWork.Teachers.GetAllTeachersAsync();

        return PartialView("_SelectTeacherToCourse", teachers);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }

    public async Task<IActionResult> AssignStudentsToCourse(int courseId)
    {
      try
      {
        Thread.Sleep(1000);

        var assignStudentToCourseDtos = await this.unitOfWork.Students.GetStudentsThatNotInCourseAsync(courseId);

        var AssignStudentToCourseViewModel = new ManageStudentInCourseViewModel
        {
          Students = assignStudentToCourseDtos.ToList(),
          CourseId = courseId
        };

        return PartialView("_AssignStudentsToCourse", AssignStudentToCourseViewModel);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AssignStudentsToCourse(ManageStudentInCourseViewModel model)
    {
      try
      {
        Thread.Sleep(1000);
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        await this.unitOfWork.Teachers.AssignStudentsToCourseAsync(model.CourseId, model.Students);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        var course = await this.unitOfWork.Courses.GetCourseAsync(model.CourseId);

        return PartialView("_TeacherCourseRow", course);
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }

    public async Task<IActionResult> RemoveStudentsFromCourse(int courseId)
    {
      Thread.Sleep(1000);

      var studentsInCourse = await this.unitOfWork.Students.GetStudentsThatAreInCourseAsync(courseId);

      var AssignStudentToCourseViewModel = new ManageStudentInCourseViewModel
      {
        Students = studentsInCourse.ToList(),
        CourseId = courseId
      };

      return PartialView("_RemoveStudentsFromCourse", AssignStudentToCourseViewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveStudentsToCourse(ManageStudentInCourseViewModel model)
    {
      try
      {
        Thread.Sleep(1000);
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        this.unitOfWork.Teachers.RemoveStudentsFromCourse(model.CourseId, model.Students);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        var course = await this.unitOfWork.Courses.GetCourseAsync(model.CourseId);

        return PartialView("_TeacherCourseRow", course);
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteTeacher(int id)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }

        // ToDo: Check if teacher exist before deleting

        await this.unitOfWork.Teachers.DeleteTeacherAsync(id);

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