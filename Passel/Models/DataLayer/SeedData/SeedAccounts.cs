using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Passel.Models
{
	internal class SeedAccounts : IEntityTypeConfiguration<Account>
	{
		public void Configure(EntityTypeBuilder<Account> entity)
		{
			entity.HasData(
				new Account
				{
					AccountID = 1,
					Email = "test@test.comm",
					Password = "test"
				},
				new Account
				{
					AccountID = 2,
					Email = "test1@test.com",
					Password = "test1"
				});
		}
	}

}