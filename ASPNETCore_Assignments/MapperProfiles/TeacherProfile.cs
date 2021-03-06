﻿using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;
using AutoMapper;

namespace ASPNETCore_Assignments.MapperProfiles
{
	public class TeacherProfile : Profile
	{
		public TeacherProfile()
		{
			CreateMap<TeacherEntity, Teacher>();
			CreateMap<TeacherForCreatingDto, TeacherEntity>();
      CreateMap<TeacherEntity, TeacherForUpdatingDto>().ReverseMap();
    }
	}
}
