using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseRepository
	{
		Task<Course> GetCourse(int courseId);
		Task<IEnumerable<Course>> GetAllCourses();

		Task AddCourse(CourseForCreatingDto dto);
		Task<int> DeleteCourse(int courseId);
	}
}
