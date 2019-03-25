using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using AutoMapper;
using System.Linq;

namespace ASPNETCore_Assignments.MapperProfiles
{
	public class CourseProfile : Profile
	{
		public CourseProfile()
		{
			CreateMap<CourseEntity, Course>()
				.ForMember(model => model.Students, opt => opt.MapFrom(x => x.StudentCourses.Select(y => y.Student)));
			CreateMap<CourseForCreatingDto, CourseEntity>()
				.ForMember(model => model.CourseAssignments, opt => opt.MapFrom(x => x.CourseAssignmets));
		}
	}
}
