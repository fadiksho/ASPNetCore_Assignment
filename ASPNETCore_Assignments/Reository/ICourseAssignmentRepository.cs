using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseAssignmentRepository
	{
		Task<CourseAssignment> GetCourseAssignment(int courseAssignmentId);
		Task<IEnumerable<CourseAssignment>> GetAllCourseAssignments();

		Task<int> AddCourseAssignment();
		Task<int> DeleteCourseAssignment(int courseAssignmentId);
	}
}
