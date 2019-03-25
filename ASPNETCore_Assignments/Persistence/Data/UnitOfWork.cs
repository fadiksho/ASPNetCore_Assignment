using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository;
using ASPNETCore_Assignments.Reository.Data;

namespace ASPNETCore_Assignments.Persistence.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly SchoolManagementContext _context;

		public UnitOfWork(SchoolManagementContext context)
		{
			this._context = context;
			this.Students = new StudentRepository(context);
			this.Teachers = new TeacherRepository(context);
			this.Courses = new CourseRepository(context);
			this.CourseAssignment = new CourseAssignmentRepository(context);
		}

		public IStudentRepository Students { get; private set; }
		public ITeacherRepository Teachers { get; private set; }
		public ICourseRepository Courses { get; private set; }
		public ICourseAssignmentRepository CourseAssignment { get; private set; }

		public Task<bool> SaveAsync()
		{
			throw new System.NotImplementedException();
		}
	}
}
