using Microsoft.EntityFrameworkCore;
using NISLAVITZ_API_SERVICES.Tables;

namespace NISLAVITZ_API_SERVICES.Contexts
{
	public class UsersContext : DbContext
	{
		public DbSet<Users> Users { get; set; }

		public UsersContext(DbContextOptions<UsersContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}
	}
}
