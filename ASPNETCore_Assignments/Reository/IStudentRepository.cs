using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface IStudentRepository
	{
		Task<Student> GetStudent(int studentId);
		Task<IEnumerable<Student>> GetAllStudents();

		Task<int> AddStudent(StudentForCreatingDto dto);
		Task<int> DeleteStudent(int studentId);
	}
}
