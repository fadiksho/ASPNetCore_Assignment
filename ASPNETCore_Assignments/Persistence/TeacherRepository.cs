using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
	public class TeacherRepository : ITeacherRepository
	{
		private readonly SchoolManagementContext _context;

		public TeacherRepository(SchoolManagementContext context)
		{
			this._context = context;
		}

		public Task<int> AddTeacher()
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteTeacher(int teacherId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Teacher>> GetAllTeachers()
		{
			throw new NotImplementedException();
		}

		public Task<Teacher> GetTeacher(int teacherId)
		{
			throw new NotImplementedException();
		}
	}
}
