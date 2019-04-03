using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using AutoMapper;
using System.Linq;

namespace ASPNETCore_Assignments.MapperProfiles
{
	public class StudentProfile : Profile
	{
		public StudentProfile()
		{
			CreateMap<StudentEntity, Student>()
				.ForMember(model => model.Courses, opt => opt.MapFrom(x => x.StudentCourses.Select(y => y.Course)));
			CreateMap<StudentEntity, ManageStudentInCourseDto>();
			CreateMap<StudentForCreatingDto, StudentEntity>();
		}
	}
}
