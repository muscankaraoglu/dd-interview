using System;
using DD.Interview.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DD.Interview.Data.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<User> Users { get; set; }
	}
}

