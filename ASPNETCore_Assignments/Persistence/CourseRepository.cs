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

		public async Task AddCourse(CourseForCreatingDto dto)
		{
			var courseEntity = this._mapper.Map<CourseEntity>(dto);

			await this._context.Courses.AddAsync(courseEntity);
		}

		public Task<int> DeleteCourse(int courseId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Course>> GetAllCourses()
		{
			var courseEntities = await this._context.Courses
				.Include(c => c.Teacher)
				.Include(c => c.CourseAssignments)
				.Include(c => c.StudentCourses)
				.ThenInclude(c => c.Student)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<Course>>(courseEntities);
		}

		public async Task<Course> GetCourse(int courseId)
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
	}
}
