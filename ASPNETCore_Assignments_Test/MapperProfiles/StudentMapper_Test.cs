using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments_Test.Utility;
using AutoMapper;
using System.Collections.Generic;
using Xunit;

namespace ASPNETCore_Assignments_Test.MapperProfiles
{
	public class StudentMapper_Test
	{
		[Fact]
		public void ConvertStudentEntityToStudentModelType()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<StudentProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var studentEntity = new StudentEntity();

			// act
			var studentModel = iMapper.Map<Student>(studentEntity);

			// assert
			Assert.IsType<Student>(studentModel);
		}

		[Fact]
		public void CheckPropertiesValueAfterConvertingFromStudentEntityToStudentModel()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<StudentProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var studentEntity = new StudentEntity
			{
				Id = 1,
				Name = "student name",
				StudentCourses = new List<StudentCourseEntity>()
				{
					new StudentCourseEntity() { Course = new CourseEntity() },
					new StudentCourseEntity() { Course = new CourseEntity() },
				}
			};
			var expectedModel = new Student
			{
				Id = 1,
				Name = "student name",
				Courses = new List<Course>()
				{
					new Course(),
					new Course()
				}
			};

			// act
			var studentModel = iMapper.Map<Student>(studentEntity);

			// assert
			Assert.True(CompareClasses.IsStudentsEqual(expectedModel, studentModel));
			Assert.IsType<List<Course>>(studentModel.Courses);
			Assert.Equal(expectedModel.Courses.Count, studentModel.Courses.Count);
		}
	}
}
