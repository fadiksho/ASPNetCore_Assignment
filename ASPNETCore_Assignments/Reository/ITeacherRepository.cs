using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ITeacherRepository
	{
		Task<Teacher> GetTeacherAsync(int teacherId);
		Task<IEnumerable<Teacher>> GetAllTeachersAsync();
		
		Task AddTeacherAsync(TeacherForCreatingDto dto);
		Task DeleteTeacherAsync(int teacherId);
	}
}
