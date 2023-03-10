using System;
using Microsoft.AspNetCore.Identity;

namespace DD.Interview.Domain.Users
{
	public class User : IdentityUser<int>
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Organization { get; set; }
	}
}

