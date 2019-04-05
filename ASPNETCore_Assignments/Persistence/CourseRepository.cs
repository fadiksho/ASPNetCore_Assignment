using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
	public class CourseRepository : ICourseRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public CourseRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public async Task AddCourseAsync(CourseForCreatingDto dto)
		{
			var courseEntity = this._mapper.Map<CourseEntity>(dto);

			await this._context.Courses.AddAsync(courseEntity);
		}

		public async Task DeleteCourseAsync(int courseId)
		{
			var course = await this._context.Courses
				.Where(c => c.Id == courseId)
				.FirstOrDefaultAsync();

			this._context.Courses.Remove(course);
		}

		public async Task<IEnumerable<Course>> GetAllCoursesAsync()
		{
			var courseEntities = await this._context.Courses
				.Include(c => c.Teacher)
				.Include(c => c.CourseAssignments)
				.Include(c => c.StudentCourses)
				.ThenInclude(c => c.Student)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<Course>>(courseEntities);
		}

		public async Task<Course> GetCourseAsync(int courseId)
		{
			var courseEntity = await this._context.Courses
				.Where(c => c.Id == courseId)
				.Include(c => c.Teacher)
				.Include(c => c.CourseAssignments)
				.Include(c => c.StudentCourses)
				.ThenInclude(c => c.Student)
				.FirstOrDefaultAsync();

			return this._mapper.Map<Course>(courseEntity);
		}
    public async Task UpdateCourseAsync(int courseId, CourseForUpdatingDto dto)
    {
      var courseEntity = await this._context.Courses
        .Where(s => s.Id == courseId)
        .FirstOrDefaultAsync();

      this._mapper.Map(dto, courseEntity);
    }
    public async Task AssignStudentsToCourseAsync(int courseId, List<int> studentsId)
    {
      var studenToCourses = new List<StudentCourseEntity>();
      foreach (var studenId in studentsId)
      {
        var studentcourse = new StudentCourseEntity
        {
          CourseId = courseId,
          StudentId = studenId
        };
        studenToCourses.Add(studentcourse);
      }
      if (studenToCourses.Count > 0)
        await this._context.AddRangeAsync(studenToCourses);
    }
    public async Task AssignStudentsToCourseAsync(int courseId, List<ManageStudentInCourseDto> students)
    {
      var studentIds = students.Where(c => c.IsSelected).Select(s => s.Id).ToList();

      await this.AssignStudentsToCourseAsync(courseId, studentIds);
    }
    public void RemoveStudentsFromCourse(int courseId, List<int> studentsId)
    {
      var studenToCourses = new List<StudentCourseEntity>();
      foreach (var studenId in studentsId)
      {
        var studentcourse = new StudentCourseEntity
        {
          CourseId = courseId,
          StudentId = studenId
        };
        studenToCourses.Add(studentcourse);
      }
      if (studenToCourses.Count > 0)
        this._context.RemoveRange(studenToCourses);
    }
    public void RemoveStudentsFromCourse(int courseId, List<ManageStudentInCourseDto> students)
    {
      var studentIds = students.Where(c => c.IsSelected).Select(s => s.Id).ToList();

      this.RemoveStudentsFromCourse(courseId, studentIds);
    }
  }
}
