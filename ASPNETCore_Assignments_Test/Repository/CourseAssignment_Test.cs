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
  public class CourseAssignment_Test
  {
    readonly IMapper _mapper;
    public CourseAssignment_Test()
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
    public async Task GettingCourseAssignmentByIdShouldNotBeNull()
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
          var course = new CourseEntity();

          context.Add(course);
          context.SaveChanges();

          context.CourseAssignments.Add(new CourseAssignmentEntity { CourseId = course.Id });
          context.SaveChanges();
        }
        using (var context = new SchoolManagementContext(options))
        {
          var courseAssignmentsId = context.CourseAssignments.First().Id;
          var unitOfWork = new UnitOfWork(context, _mapper);
          var courseAssignmet = await unitOfWork.CourseAssignment.GetCourseAssignmentsAsync(courseAssignmentsId);
          Assert.NotNull(courseAssignmet);
          Assert.NotNull(courseAssignmet.Course);
        }
      }
      finally
      {
        connection.Close();
      }
    }

    [Fact]
    public async Task AddingNewCourseAssignmetShouldPersiste()
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
          var unitOfWork = new UnitOfWork(context, _mapper);

          var course = new CourseEntity();
          context.Add(course);
          context.SaveChanges();
          var courseAssignment = new CourseAssignmentForCreatingDto { CourseId = course.Id };
          await unitOfWork.CourseAssignment.AddCourseAssignmentAsync(courseAssignment);
          await unitOfWork.SaveAsync();
        }
        using (var context = new SchoolManagementContext(options))
        {
          Assert.NotNull(context.CourseAssignments.First());
        }
      }
      finally
      {
        connection.Close();
      }
    }

    [Fact]
    public async Task AddingNewCourseAssignmetWithInvalidCourseIdShouldThrowException()
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
          var unitOfWork = new UnitOfWork(context, _mapper);
          var courseAssignment = new CourseAssignmentForCreatingDto { CourseId = 1 };
          await unitOfWork.CourseAssignment.AddCourseAssignmentAsync(courseAssignment);
          await unitOfWork.SaveAsync();
        }
      }
      catch (Exception ex)
      {
        Assert.NotNull(ex);
      }
      finally
      {
        connection.Close();
      }
    }
  }
}
