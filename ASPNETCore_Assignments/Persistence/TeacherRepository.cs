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
	public class TeacherRepository : ITeacherRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public TeacherRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public async Task AddTeacherAsync(TeacherForCreatingDto dto)
		{
			var teacherEntity = this._mapper.Map<TeacherEntity>(dto);

			await this._context.Teachers.AddAsync(teacherEntity);
		}

		public Task DeleteTeacherAsync(int teacherId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
		{
			var teacherEntities = await this._context.Teachers
				.Include(t => t.Courses)
				.ToListAsync();

			return _mapper.Map<IEnumerable<Teacher>>(teacherEntities);
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
	}
}
