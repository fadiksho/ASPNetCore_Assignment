using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Persistence.Data;
using AutoMapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASPNETCore_Assignments_Test.Repository
{
	public class StudentRepository_Test
	{
		readonly IMapper _mapper;
		public StudentRepository_Test()
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
		public async Task GettingStudentByIdShouldNotBeNull()
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
					var student = new StudentEntity	{	Name = "name" };
					var courses = new List<CourseEntity>
					{
						new CourseEntity(),
						new CourseEntity()
					};
					var studentsToCourses = new StudentCourseEntity[]
					{
						new StudentCourseEntity { Student = student, Course = courses[0] },
						new StudentCourseEntity { Student = student, Course = courses[1] },
					};
					context.AddRange(studentsToCourses);
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var studentId = context.Students.First().Id;
					var student = await unitOfWork.Students.GetStudentAsync(studentId);
					Assert.NotNull(student);
					Assert.Equal(2, student.Courses.Count);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task AddingNewStudentShouldPersiste()
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
					await unitOfWork.Students.AddStudentAsync(new StudentForCreatingDto { Name = "name" });
					await unitOfWork.SaveAsync();
				}
				using (var context = new SchoolManagementContext(options))
				{
					Assert.Equal(1, context.Students.Count());
				}
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
