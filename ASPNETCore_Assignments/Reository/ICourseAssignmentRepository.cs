using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseAssignmentRepository
	{
		Task<CourseAssignment> GetAssignmentAsync(int courseAssignmentId);
		Task<IEnumerable<CourseAssignment>> GetAllCourseAssignmentsAsync();

		Task AddCourseAssignmentAsync(CourseAssignmentForCreatingDto dto);
		Task<int> DeleteCourseAssignmentAsync(int courseAssignmentId);

    Task<IEnumerable<CourseAssignmentForCreatingDto>> GetAssignmentsForCourse(int courseId);
    Task SetAssignmentsForCourseAsync(int courseId, IEnumerable<CourseAssignmentForCreatingDto> assignments);
  }
}
