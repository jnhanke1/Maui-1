using System;
using Microsoft.EntityFrameworkCore;

namespace Maui.Models
{
	public class UserDbContext : DbContext
	{
		public UserDbContext (DbContextOptions<UserDbContext> options)
			: base(options)
		{
		}

	
		public DbSet<User> Users {get; set;} = default!;

		public DbSet<Network> Networks {get; set;} = default!;

		public DbSet<Marketer> Marketers {get; set;} = default!;

		public DbSet<DataCollector> DataCollectors {get; set;} = default!;

		public DbSet<CaptivePortal> CaptivePortals {get; set;} = default!;

		public DbSet<Admin> Admins {get; set;} = default!;
	}
}