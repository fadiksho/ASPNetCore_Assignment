using ASPNETCore_Assignments.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Xunit;
using AutoMapper;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.DTO;
using System.Threading.Tasks;
using System.Linq;
using ASPNETCore_Assignments.Entity;
using System.Collections.Generic;

namespace ASPNETCore_Assignments_Test.Repository
{
	public class TeacherRepository_Test
	{
		readonly IMapper _mapper;
		public TeacherRepository_Test()
		{
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<CourseProfile>();
				cfg.AddProfile<CourseAssignmentProfile>();
				cfg.AddProfile<StudentProfile>();
			});
			this._mapper = mapperConfig.CreateMapper();
		}

		[Fact]
		public async Task GettingTeacherByIdShouldNotBeNull()
		{
			var connection = new SqliteConnection("DataSource=:memory:");
			connection.Open();
			try
			{
				var options = new DbContextOptionsBuilder<SchoolManagementContext>()
						.UseSqlite(connection)
						.Options;

				using (var context = new SchoolManagementContext(options))
				{
					context.Database.EnsureCreated();
				}
				using (var context = new SchoolManagementContext(options))
				{
					context.Teachers.Add(
						new TeacherEntity
						{
							Name = "name",
							Courses = new List<CourseEntity>
							{
								new CourseEntity(),
								new CourseEntity()
							}
						});
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var existingTeacher = context.Teachers.First();
					var teacher = await unitOfWork.Teachers.GetTeacherAsync(existingTeacher.Id);
					Assert.NotNull(teacher);
					Assert.Equal(2, teacher.Courses.Count);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task AddingNewTeacherShouldPersiste()
		{
			var connection = new SqliteConnection("DataSource=:memory:");
			connection.Open();
			try
			{
				var options = new DbContextOptionsBuilder<SchoolManagementContext>()
						.UseSqlite(connection)
						.Options;

				using (var context = new SchoolManagementContext(options))
				{
					context.Database.EnsureCreated();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					await unitOfWork.Teachers.AddTeacherAsync(new TeacherForCreatingDto { Name = "name" });
					await unitOfWork.SaveAsync();
				}
				using (var context = new SchoolManagementContext(options))
				{
					Assert.Equal(1, context.Teachers.Count());
				}
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
