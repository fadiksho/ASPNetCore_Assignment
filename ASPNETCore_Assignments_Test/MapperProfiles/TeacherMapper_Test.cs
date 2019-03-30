using ASPNETCore_Assignments.DTO;
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
		public void TheNavigationPropertyAfterConvertingEntityToModelAreNotNull()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<CourseProfile>();
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<StudentProfile>();
				cfg.AddProfile<CourseAssignmentProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var teacherEntity = new TeacherEntity();

			var courseEntity = new CourseEntity
			{
				Teacher = teacherEntity,
				CourseAssignments = new List<CourseAssignmentEntity>
				{
					new CourseAssignmentEntity(),
					new CourseAssignmentEntity()
				}
			};
			var studentsToCourses = new StudentCourseEntity[]
			{
					new StudentCourseEntity { Student = new StudentEntity(), Course = courseEntity },
					new StudentCourseEntity { Student = new StudentEntity(), Course = courseEntity },
					new StudentCourseEntity { Student = new StudentEntity(), Course = courseEntity },
			};
			courseEntity.StudentCourses = studentsToCourses;
			teacherEntity.Courses = new List<CourseEntity>
			{
				courseEntity
			};

			// act
			var expectedModel = iMapper.Map<Teacher>(teacherEntity);
			// assert
			Assert.NotNull(expectedModel.Courses);
			foreach (var course in teacherEntity.Courses)
			{
				foreach (var sc in course.StudentCourses)
				{
					Assert.NotNull(sc.Course);
					Assert.NotNull(sc.Student);
				}
			}
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

		[Fact]
		public void ConvertTeacherForCreatingDtoToTeacherEntityType()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var studentForCreatingDto = new TeacherForCreatingDto();
			
			// act
			var studentModel = iMapper.Map<TeacherEntity>(studentForCreatingDto);

			// assert
			Assert.IsType<TeacherEntity>(studentModel);
		}

		[Fact]
		public void CheckPropertiesValueAfterConvertingTeacherForCreatingDtoToTeacherEntity()
		{
			// arrange
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<TeacherProfile>();
				cfg.AddProfile<CourseProfile>();
			});
			var iMapper = mapperConfig.CreateMapper();
			var teacherEntity = new TeacherForCreatingDto
			{
				Name = "name"
			};
			var expecteModel = new TeacherEntity
			{
				Name = "name"
			};

			// act
			var model = iMapper.Map<TeacherEntity>(teacherEntity);

			// assert
			Assert.True(CompareClasses.IsTeacherEntitiesEqual(expecteModel, model));
		}
	}
}
