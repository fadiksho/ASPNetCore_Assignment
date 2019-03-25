using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
	public class CourseAssignmentRepository : ICourseAssignmentRepository
	{
		private readonly SchoolManagementContext _context;

		public CourseAssignmentRepository(SchoolManagementContext context)
		{
			this._context = context;
		}

		public Task<int> AddCourseAssignment()
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteCourseAssignment(int courseAssignmentId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<CourseAssignment>> GetAllCourseAssignments()
		{
			throw new NotImplementedException();
		}

		public Task<CourseAssignment> GetCourseAssignment(int courseAssignmentId)
		{
			throw new NotImplementedException();
		}
	}
}
