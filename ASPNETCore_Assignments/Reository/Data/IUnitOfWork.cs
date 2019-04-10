using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository.Data
{
	public interface IUnitOfWork
	{
		IStudentRepository Students { get; }
		ITeacherRepository Teachers { get; }
		ICourseRepository Courses { get; }
		ICourseAssignmentRepository CourseAssignment { get; }

		Task<bool> SaveAsync();
	}
}
