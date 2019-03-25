using ASPNETCore_Assignments.DTO;
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

		public Task<int> AddStudent(StudentForCreatingDto dto)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteStudent(int studentId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Student>> GetAllStudents()
		{
			var studentEntities = await this._context.Students
				.Include(sc => sc.StudentCourses)
				.ThenInclude(c => c.Course)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<Student>>(studentEntities);
		}

		public async Task<Student> GetStudent(int studentId)
		{
			var studentEntity = await this._context.Students
				.Where(s => s.Id == studentId)
				.Include(sc => sc.StudentCourses)
				.ThenInclude(c => c.Course)
				.FirstOrDefaultAsync();

			return this._mapper.Map<Student>(studentEntity);
		}
	}
}
