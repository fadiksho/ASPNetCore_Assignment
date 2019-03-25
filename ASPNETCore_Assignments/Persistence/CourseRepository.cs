using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
	public class CourseRepository : ICourseRepository
	{
		private readonly SchoolManagementContext _context;

		public CourseRepository(SchoolManagementContext context)
		{
			this._context = context;
		}

		public Task<int> AddCourse()
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteCourse(int courseId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Course>> GetAllCourses()
		{
			throw new NotImplementedException();
		}

		public Task<Course> GetCourse(int courseId)
		{
			throw new NotImplementedException();
		}
	}
}
