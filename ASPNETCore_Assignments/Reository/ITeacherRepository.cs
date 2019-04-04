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

    Task AssignTeacherToCourseAsync(int? teacherId, int courseId);
		Task AssignStudentsToCourseAsync(int courseId, List<int> studentsId);
		Task AssignStudentsToCourseAsync(int courseId, List<ManageStudentInCourseDto> students);
		void RemoveStudentsFromCourse(int courseId, List<int> studentsId);
		void RemoveStudentsFromCourse(int courseId, List<ManageStudentInCourseDto> students);
	}
}
