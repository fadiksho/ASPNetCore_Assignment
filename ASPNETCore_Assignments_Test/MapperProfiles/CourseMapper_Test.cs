using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments_Test.Utility;
using AutoMapper;
using System.Collections.Generic;
using Xunit;

namespace ASPNETCore_Assignments_Test.MapperProfiles
{
	public class CourseMapper_Test
	{
		[Fact]
		public void ConvertCourseEntityToCourseModelType()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var courseEntity = new CourseEntity
			{
				Teacher = new TeacherEntity(),
				StudentCourses = new List<StudentCourseEntity>
				{
					new StudentCourseEntity(),
					new StudentCourseEntity()
				}
			};

			// act
			var model = iMapper.Map<Course>(courseEntity);

			// assert
			Assert.IsType<Course>(model);
			Assert.IsType<Teacher>(model.Teacher);
		}

		[Fact]
		public void CheckPropertiesValueAfterConvertingFromCourseEntityToCourseModel()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<CourseProfile>();
				cfg.AddProfile<StudentProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var courseEntity = new CourseEntity
			{
				Id = 1,
				Name = "name",
				Description = "description",
				Teacher = new TeacherEntity(),
				StudentCourses = new List<StudentCourseEntity>
				{
					new StudentCourseEntity(),
					new StudentCourseEntity()
				},
				CourseAssignments = new List<CourseAssignmentEntity>
				{
					new CourseAssignmentEntity(),
					new CourseAssignmentEntity()
				}
			};
			var expecteModel = new Course
			{
				Id = 1,
				Name = "name",
				Description = "description",
				Teacher = new Teacher(),
				CourseAssignments = new List<CourseAssignment>
				{
					new CourseAssignment(),
					new CourseAssignment()
				},
				Students = new List<Student>()
				{
					new Student(),
					new Student()
				}
			};

			// act
			var model = iMapper.Map<Course>(courseEntity);

			// assert
			Assert.True(CompareClasses.IsCoursesEqual(expecteModel, model));
			Assert.IsType<List<Student>>(model.Students);
			Assert.IsType<List<CourseAssignment>>(model.CourseAssignments);
			Assert.Equal(expecteModel.Students.Count, model.Students.Count);
			Assert.Equal(expecteModel.CourseAssignments.Count, model.CourseAssignments.Count);
		}
	}
}
