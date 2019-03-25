using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using AutoMapper;

namespace ASPNETCore_Assignments.MapperProfiles
{
	public class CourseAssignmentProfile : Profile
	{
		public CourseAssignmentProfile()
		{
			CreateMap<CourseAssignmentEntity, CourseAssignment>();
			CreateMap<CourseAssignmentForCreatingDto, CourseAssignmentEntity>();
		}
	}
}
