using Microsoft.EntityFrameworkCore;

namespace Maui.Models
{
	public class UserDbContext : DbContext
	{
		public UserDbContextDbContext (DbContextOptions<UserDbContext> options)
			: base(options)
		{
		}
		public DbSet<User> Users {get; set;} = default!;
	}
}