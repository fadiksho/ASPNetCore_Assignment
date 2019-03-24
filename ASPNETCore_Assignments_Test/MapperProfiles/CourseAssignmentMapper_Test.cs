using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments_Test.Utility;
using AutoMapper;
using Xunit;

namespace ASPNETCore_Assignments_Test.MapperProfiles
{
	public class CourseAssignmentMapper_Test
	{
		[Fact]
		public void ConvertCourseAssignmentEntityToCourseAssignmentModelType()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<CourseAssignmentProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var courseAssignmentEntity = new CourseAssignmentEntity
			{
				Course = new CourseEntity()
			};

			// act
			var model = iMapper.Map<CourseAssignment>(courseAssignmentEntity);

			// assert
			Assert.IsType<CourseAssignment>(model);
			Assert.IsType<Course>(model.Course);
		}

		[Fact]
		public void CheckPropertiesValueAfterConvertingFromCourseAssignmentEntityToCourseAssignmentModel()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<CourseAssignmentProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var courseAssignmentEntity = new CourseAssignmentEntity
			{
				Id = 1,
				IsDone = true,
				Name = "Course Assignment 1",
				Course = new CourseEntity()
			};
			var expectedModel = new CourseAssignment
			{
				Id = 1,
				IsDone = true,
				Name = "Course Assignment 1",
				Course = new Course()
			};

			// act
			var model = iMapper.Map<CourseAssignment>(courseAssignmentEntity);

			// assert
			Assert.True(CompareClasses.IsCourseAssignmentEqual(expectedModel, model));
			Assert.NotNull(model.Course);
		}
	}
}
