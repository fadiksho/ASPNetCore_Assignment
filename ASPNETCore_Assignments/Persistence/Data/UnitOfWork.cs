using System.Threading.Tasks;
using ASPNETCore_Assignments.Reository;
using ASPNETCore_Assignments.Reository.Data;
using AutoMapper;

namespace ASPNETCore_Assignments.Persistence.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly SchoolManagementContext _context;

		public UnitOfWork(SchoolManagementContext context, Mapper mapper)
		{
			this._context = context;
			this.Students = new StudentRepository(context, mapper);
			this.Teachers = new TeacherRepository(context, mapper);
			this.Courses = new CourseRepository(context, mapper);
			this.CourseAssignment = new CourseAssignmentRepository(context, mapper);
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
