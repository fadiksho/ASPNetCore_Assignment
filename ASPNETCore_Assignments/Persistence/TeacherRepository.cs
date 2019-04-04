using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
  public class TeacherRepository : ITeacherRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public TeacherRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}
		
		public async Task<Teacher> GetTeacherAsync(int teacherId)
		{
			var teacherEntity = await this._context.Teachers
				.Where(t => t.Id == teacherId)
				.Include(c => c.Courses)
					.ThenInclude(sc => sc.StudentCourses)
						.ThenInclude(sc => sc.Student)
				.Include(c => c.Courses)
					.ThenInclude(ca => ca.CourseAssignments)
				.FirstOrDefaultAsync();

			return _mapper.Map<Teacher>(teacherEntity);
		}
		public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
		{
			var teacherEntities = await this._context.Teachers
				.Include(t => t.Courses)
				.ToListAsync();

			return _mapper.Map<IEnumerable<Teacher>>(teacherEntities);
		}

		public async Task AddTeacherAsync(TeacherForCreatingDto dto)
		{
			var teacherEntity = this._mapper.Map<TeacherEntity>(dto);

			await this._context.Teachers.AddAsync(teacherEntity);
		}
		public async Task DeleteTeacherAsync(int teacherId)
		{
      var teacher = await this._context.Teachers
        .Where(t => t.Id == teacherId)
        .FirstOrDefaultAsync();

      this._context.Teachers.Remove(teacher);
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
