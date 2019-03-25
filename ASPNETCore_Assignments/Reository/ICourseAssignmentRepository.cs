using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseAssignmentRepository
	{
		Task<CourseAssignment> GetCourseAssignmentAsync(int courseAssignmentId);
		Task<IEnumerable<CourseAssignment>> GetAllCourseAssignmentsAsync();

		Task AddCourseAssignmentAsync(CourseAssignmentForCreatingDto dto);
		Task<int> DeleteCourseAssignmentAsync(int courseAssignmentId);
	}
}
