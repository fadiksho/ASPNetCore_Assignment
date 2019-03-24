using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.MapperProfiles;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments_Test.Utility;
using AutoMapper;
using System.Collections.Generic;
using Xunit;

namespace ASPNETCore_Assignments_Test.MapperProfiles
{
	public class TeacherMapper_Test
	{
		[Fact]
		public void ConvertTeacherEntityToTeacherModelType()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var studentEntity = new TeacherEntity();

			// act
			var studentModel = iMapper.Map<Teacher>(studentEntity);

			// assert
			Assert.IsType<Teacher>(studentModel);
		}

		[Fact]
		public void CheckPropertiesValueAfterConvertingFromTeacherEntityToTeacherModel()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var teacherEntity = new TeacherEntity
			{
				Id = 1,
				Name = "name",
				Courses = new List<CourseEntity>
				{
					new CourseEntity(),
					new CourseEntity()
				}
			};
			var expecteModel = new Teacher
			{
				Id = 1,
				Name = "name",
				Courses = new List<Course>
				{
					new Course(),
					new Course()
				}
			};

			// act
			var model = iMapper.Map<Teacher>(teacherEntity);

			// assert
			Assert.True(CompareClasses.IsTeachersEqual(expecteModel, model));
			Assert.IsType<List<Course>>(model.Courses);
			Assert.Equal(expecteModel.Courses.Count, model.Courses.Count);
		}
	}
}
