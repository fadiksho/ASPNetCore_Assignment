﻿namespace ASPNETCore_Assignments.Services
{
	public class AppSettings
	{
		public ConnectionStrings ConnectionStrings { get; set; }
	}

	public class ConnectionStrings
	{
		public string DefaultConnection { get; set; }
	}
}
