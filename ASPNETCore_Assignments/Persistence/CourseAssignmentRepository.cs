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
	public class CourseAssignmentRepository : ICourseAssignmentRepository
	{
		private readonly SchoolManagementContext _context;
		private readonly IMapper _mapper;

		public CourseAssignmentRepository(SchoolManagementContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public async Task AddCourseAssignmentAsync(CourseAssignmentForCreatingDto dto)
		{
			var courseAssignmentEntity = this._mapper.Map<CourseAssignmentEntity>(dto);

			await this._context.CourseAssignments.AddAsync(courseAssignmentEntity);
		}

		public Task<int> DeleteCourseAssignmentAsync(int courseAssignmentId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<CourseAssignment>> GetAllCourseAssignmentsAsync()
		{
			var courseAssignmentEntities = await this._context.CourseAssignments
				.Include(ca => ca.Course)
				.ToListAsync();

			return this._mapper.Map<IEnumerable<CourseAssignment>>(courseAssignmentEntities);
		}

		public async Task<CourseAssignment> GetCourseAssignmentAsync(int courseAssignmentId)
		{
			var courseAssignmentEntity = await this._context.CourseAssignments
				.Where(ca => ca.Id == courseAssignmentId)
				.Include(ca => ca.Course)
				.FirstOrDefaultAsync();

			return this._mapper.Map<CourseAssignment>(courseAssignmentEntity);
		}
	}
}
