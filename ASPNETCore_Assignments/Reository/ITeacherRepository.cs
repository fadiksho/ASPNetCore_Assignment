using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ITeacherRepository
	{
		Task<Teacher> GetTeacher(int teacherId);
		Task<IEnumerable<Teacher>> GetAllTeachers();
		
		Task<int> AddTeacher(TeacherForCreatingDto dto);
		Task<int> DeleteTeacher(int teacherId);
	}
}
