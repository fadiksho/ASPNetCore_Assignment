﻿using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Reository
{
	public interface IStudentRepository
	{
		Task<Student> GetStudentAsync(int studentId);
		Task<IEnumerable<Student>> GetAllStudentsAsync();

		Task AddStudentAsync(StudentForCreatingDto dto);
		Task DeleteStudentAsync(int studentId);
    Task UpdateStudentAsync(int studentId, StudentForUpdatingDto dto);

		Task<IEnumerable<ManageStudentInCourseDto>> GetStudentsThatNotInCourseAsync(int courseId);
		Task<IEnumerable<ManageStudentInCourseDto>> GetStudentsThatAreInCourseAsync(int courseId);
	}
}
