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
	public class StudentRepository : IStudentRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public StudentRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public async Task AddStudentAsync(StudentForCreatingDto dto)
		{
			var studentEntity = this._mapper.Map<StudentEntity>(dto);

			await this._context.Students.AddAsync(studentEntity);
		}

		public Task DeleteStudentAsync(int studentId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Student>> GetAllStudentsAsync()
		{
			var studentEntities = await this._context.Students
				.Include(sc => sc.StudentCourses)
				.ThenInclude(c => c.Course)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<Student>>(studentEntities);
		}

		public async Task<Student> GetStudentAsync(int studentId)
		{
			var studentEntity = await this._context.Students
				.Where(s => s.Id == studentId)
				.Include(sc => sc.StudentCourses)
					.ThenInclude(c => c.Course)
					.ThenInclude(t => t.Teacher)
				.Include(sc => sc.StudentCourses)
					.ThenInclude(c => c.Course)
					.ThenInclude(ca => ca.CourseAssignments)
				.FirstOrDefaultAsync();
			
			return this._mapper.Map<Student>(studentEntity);
		}

		public async Task<IEnumerable<AssignStudentToCourseDto>> GetStudentsThatNotInCourseAsync(int courseId)
		{
			var studentEntities = await this._context.Students
				.Include(sc => sc.StudentCourses)
				.Where(s => !s.StudentCourses.Any(sc => sc.CourseId == courseId))
				.ToListAsync();

			return this._mapper.Map<IEnumerable<AssignStudentToCourseDto>>(studentEntities);
		}
	}
}
