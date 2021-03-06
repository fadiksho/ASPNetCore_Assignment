﻿using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
	public class PersonDto
	{
		[Required]
		[MaxLength(30)]
		public string Name { get; set; }
		public string PhoneNumber { get; set; } = "";
		public string City { get; set; } = "";
	}
}
