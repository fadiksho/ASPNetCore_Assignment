using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Persistence.Data;
using AutoMapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ASPNETCore_Assignments_Test.Repository
{
	public class CourseRepository_Test
	{
		readonly IMapper _mapper;
		public CourseRepository_Test()
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
		public async Task GettingCourseByIdShouldNotBeNull()
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
					context.Courses.Add(new CourseEntity());
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var courseId = context.Courses.First().Id;
					var course = await unitOfWork.Courses.GetCourseAsync(courseId);
					Assert.NotNull(course);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task GettingCourseByIdCourseAssignmentsShouldNotBeNull()
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
					var course = new CourseEntity
					{
						CourseAssignments = new List<CourseAssignmentEntity>
						{
							new CourseAssignmentEntity(),
							new CourseAssignmentEntity()
						}
					};
					context.Courses.Add(course);
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var courseId = context.Courses.First().Id;
					var course = await unitOfWork.Courses.GetCourseAsync(courseId);
					Assert.NotNull(course.CourseAssignments);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task GettingCourseByIdTeacherShouldNotBeNull()
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
					var course = new CourseEntity
					{
						Teacher = new TeacherEntity()
					};
					context.Courses.Add(course);
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var courseId = context.Courses.First().Id;
					var course = await unitOfWork.Courses.GetCourseAsync(courseId);
					Assert.NotNull(course.Teacher);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task GettingCourseByIdStudentsShouldNotBeNull()
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
					var course = new CourseEntity();
					var student1 = new StudentEntity();
					var student2 = new StudentEntity();
					var studentsToCourses = new StudentCourseEntity[]
					{
						new StudentCourseEntity { Student = student1, Course = course },
						new StudentCourseEntity { Student = student2, Course = course },
					};
					context.AddRange(studentsToCourses);
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var courseId = context.Courses.First().Id;
					var course = await unitOfWork.Courses.GetCourseAsync(courseId);
					Assert.Equal(2, course.Students.Count);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task GettingCoursesShouldIncludeAllNavigationProperty()
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
					var courses = new List<CourseEntity>()
					{
						new CourseEntity()
						{
							Teacher = new TeacherEntity(),
							CourseAssignments = new List<CourseAssignmentEntity>
							{
								new CourseAssignmentEntity(),
								new CourseAssignmentEntity()
							}
						},
						new CourseEntity()
						{
							Teacher = new TeacherEntity(),
							CourseAssignments = new List<CourseAssignmentEntity>
							{
								new CourseAssignmentEntity(),
								new CourseAssignmentEntity()
							}
						}
					};
					var studentsToCourses = new StudentCourseEntity[]
					{
						new StudentCourseEntity { Student = new StudentEntity(), Course = courses[0] },
						new StudentCourseEntity { Student = new StudentEntity(), Course = courses[1] },
					};
					context.AddRange(studentsToCourses);
					context.SaveChanges();
				}
				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					var courses = await unitOfWork.Courses.GetAllCoursesAsync();
					foreach (var course in courses)
					{
						Assert.NotNull(course.CourseAssignments);
						Assert.NotNull(course.Students);
						Assert.NotNull(course.Teacher);
					}
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task AddingNewCourseShouldPersiste()
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
					var course = new CourseForCreatingDto
					{
						Name = "name"
					};
					await unitOfWork.Courses.AddCourseAsync(course);
					await unitOfWork.SaveAsync();
				}
				using (var context = new SchoolManagementContext(options))
				{
					Assert.Equal(1, context.Courses.Count());
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task AddingNewCourseWithAssignmentsShouldPersiste()
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
					var course = new CourseForCreatingDto
					{
						Name = "name",
						CourseAssignmets = new List<CourseAssignmentForCreatingDto>
						{
							new CourseAssignmentForCreatingDto(),
							new CourseAssignmentForCreatingDto()
						}
					};
					await unitOfWork.Courses.AddCourseAsync(course);
					await unitOfWork.SaveAsync();
				}
				using (var context = new SchoolManagementContext(options))
				{
					Assert.Equal(1, context.Courses.Count());
					Assert.Equal(2, context.CourseAssignments.Count());
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task AssignStudentsToCourseShouldPersiste()
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
				int courseId;
				List<int> studentsId;
				using (var context = new SchoolManagementContext(options))
				{
					var course = new CourseEntity();
					var students = new List<StudentEntity>
					{
						new StudentEntity(),
						new StudentEntity()
					};
					var studentsToCourses = new StudentCourseEntity[]
					{
						new StudentCourseEntity { Student = new StudentEntity(), Course = course },
						new StudentCourseEntity { Student = new StudentEntity(), Course = course },
					};
					context.AddRange(studentsToCourses);
					context.AddRange(students);
					context.SaveChanges();
					
					courseId = studentsToCourses[0].CourseId;
					studentsId = new List<int>
					{
						students[0].Id,
						students[1].Id,
					};
				}

				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					await unitOfWork.Teachers.AssignStudentsToCourseAsync(courseId, studentsId);
					await unitOfWork.SaveAsync();
				}

				using (var context = new SchoolManagementContext(options))
				{
					var students = context.Courses
						.Include(c => c.StudentCourses)
						.FirstOrDefault();

					Assert.Equal(4, students.StudentCourses.Count);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		[Fact]
		public async Task RemoveStudentsFromCourseShouldPersiste()
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
				int courseId;
				List<int> studentsId;
				using (var context = new SchoolManagementContext(options))
				{
					var course = new CourseEntity();

					var studentsToCourses = new StudentCourseEntity[]
					{
						new StudentCourseEntity { Student = new StudentEntity(), Course = course },
						new StudentCourseEntity { Student = new StudentEntity(), Course = course },

					};
					context.AddRange(studentsToCourses);
					context.SaveChanges();

					courseId = studentsToCourses[0].CourseId;
					studentsId = new List<int>
					{
						studentsToCourses[0].StudentId,
						studentsToCourses[1].StudentId,
					};
				}

				using (var context = new SchoolManagementContext(options))
				{
					var unitOfWork = new UnitOfWork(context, _mapper);
					unitOfWork.Teachers.RemoveStudentsFromCourse(courseId, studentsId);
					await unitOfWork.SaveAsync();
				}

				using (var context = new SchoolManagementContext(options))
				{
					var students = context.Courses
						.Include(c => c.StudentCourses)
						.FirstOrDefault();

					Assert.Equal(0, students.StudentCourses.Count);
				}
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
