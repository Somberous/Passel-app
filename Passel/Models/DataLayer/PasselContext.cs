using Microsoft.EntityFrameworkCore;
namespace Passel.Models
{
	public class PasselContext : DbContext
	{
		public PasselContext(DbContextOptions<PasselContext> options) : base(options)
		{
		}
		public DbSet<Media> Medias { get; set; }
		public DbSet<Change> Changes { get; set; }
		public DbSet<Account> Accounts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new SeedMedias());
			modelBuilder.ApplyConfiguration(new SeedChanges());
			modelBuilder.ApplyConfiguration(new SeedAccounts());
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}