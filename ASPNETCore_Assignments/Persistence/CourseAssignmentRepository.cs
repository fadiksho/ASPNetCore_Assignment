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
	public class CourseAssignmentRepository : ICourseAssignmentRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public CourseAssignmentRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public Task<int> AddCourseAssignment()
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteCourseAssignment(int courseAssignmentId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<CourseAssignment>> GetAllCourseAssignments()
		{
			var courseAssignmentEntities = await this._context.CourseAssignments
				.Include(ca => ca.Course)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<CourseAssignment>>(courseAssignmentEntities);
		}

		public async Task<CourseAssignment> GetCourseAssignment(int courseAssignmentId)
		{
			var courseAssignmentEntity = await this._context.CourseAssignments
				.Where(ca => ca.Id == courseAssignmentId)
				.Include(ca => ca.Course)
				.FirstOrDefaultAsync();

			return this._mapper.Map<CourseAssignment>(courseAssignmentEntity);
		}
	}
}
