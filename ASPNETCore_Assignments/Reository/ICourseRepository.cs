﻿using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface ICourseRepository
	{
		Task<Course> GetCourseAsync(int courseId);
		Task<IEnumerable<Course>> GetAllCoursesAsync();

		Task AddCourseAsync(CourseForCreatingDto dto);
		Task DeleteCourseAsync(int courseId);
    Task UpdateCourseAsync(int studentId, CourseForUpdatingDto dto);

    Task AssignStudentsToCourseAsync(int courseId, List<int> studentsId);
    Task AssignStudentsToCourseAsync(int courseId, List<ManageStudentInCourseDto> students);
    void RemoveStudentsFromCourse(int courseId, List<int> studentsId);
    void RemoveStudentsFromCourse(int courseId, List<ManageStudentInCourseDto> students);
  }
}
