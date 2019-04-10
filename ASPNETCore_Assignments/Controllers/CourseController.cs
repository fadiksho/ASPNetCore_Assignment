using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Reository.Data;
using ASPNETCore_Assignments.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
  [Route("/SchoolManagement/[Controller]/[action]")]
  public class CourseController : Controller
  {
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CourseController(IUnitOfWork unitOfWork, IMapper mapper)
    {
      this.unitOfWork = unitOfWork;
      this.mapper = mapper;
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
    public async Task<IActionResult> Details(int courseId)
    {
      try
      {
        Thread.Sleep(1000);
        // ToDo: Check if taecher exist before editing
        var course = await this.unitOfWork.Courses.GetCourseAsync(courseId);

        return View(course);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }
    [Route("{courseId}")]
    public async Task<IActionResult> _Details(int courseId)
    {
      try
      {
        Thread.Sleep(1000);
        // ToDo: Check if student exist before editing
        var course = await this.unitOfWork.Courses.GetCourseAsync(courseId);

        return PartialView("_CourseDetails", course);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("_ServerError");
    }
    public async Task<IActionResult> Edit(int courseId)
    {
      try
      {
        Thread.Sleep(1000);
        // ToDo: Check if course exist before editing
        var course = await this.unitOfWork.Courses.GetCourseAsync(courseId);

        var courseForUpdatingDto = this.mapper.Map<CourseForUpdatingDto>(course);

        return PartialView("_Edit", courseForUpdatingDto);
      }
      catch
      {
        // ToDo: Logging
      }
      return PartialView("_ServerError");
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int courseId, CourseForUpdatingDto dto)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState.Values);
        }
        if (courseId != dto.Id)
        {
          return BadRequest();
        }
        // ToDo: Check if student exist before editing
        await this.unitOfWork.Courses.UpdateCourseAsync(courseId, dto);

        await this.unitOfWork.SaveAsync();
        
        var course = await this.unitOfWork.Courses.GetCourseAsync(courseId);

        return PartialView("_CourseDetails", course);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
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

        await this.unitOfWork.Courses.AssignStudentsToCourseAsync(model.CourseId, model.Students);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        return RedirectToAction("_Details", "Course", new { courseId = model.CourseId });
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

        this.unitOfWork.Courses.RemoveStudentsFromCourse(model.CourseId, model.Students);

        if (!await this.unitOfWork.SaveAsync())
        {
          return PartialView("_SavingError");
        }

        return RedirectToAction("_Details", "Course", new { courseId = model.CourseId });
      }
      catch
      {
        // ToDo: Logging
      }

      return PartialView("_ServerError");
    }

    public async Task<IActionResult> SelectTeacherToCourse(int? teacherId)
    {
      try
      {
        Thread.Sleep(1000);
        var teachers = await this.unitOfWork.Teachers.GetAllTeachersAsync();
        var selectTeacherToCourseViewModel = new SelectTeacherToCourseViewModel
        {
          Teachers = teachers,
          TeacherId = teacherId
        };
        return PartialView("_SelectTeacherToCourse", selectTeacherToCourseViewModel);
      }
      catch
      {
        // ToDo: Logging
      }
      return View("ErrorRetrivingData");
    }
  }
}