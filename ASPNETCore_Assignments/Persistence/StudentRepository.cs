using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence
{
	public class StudentRepository : IStudentRepository
	{
		private readonly SchoolManagementContext _context;

		public StudentRepository(SchoolManagementContext context)
		{
			this._context = context;
		}

		public Task<int> AddStudent()
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteStudent(int studentId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Student>> GetAllStudents()
		{
			throw new NotImplementedException();
		}

		public Task<Student> GetStudent(int studentId)
		{
			throw new NotImplementedException();
		}
	}
}
