using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseRepository
	{
		Task<Course> GetCourse(int courseId);
		Task<IEnumerable<Course>> GetAllCourses();

		Task<int> AddCourse();
		Task<int> DeleteCourse(int courseId);
	}
}
