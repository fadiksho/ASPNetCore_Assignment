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
		}
	}
}
