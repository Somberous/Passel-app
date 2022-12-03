using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Passel.Models
{
	internal class SeedChanges : IEntityTypeConfiguration<Change>
	{
		public void Configure(EntityTypeBuilder<Change> entity)
		{
			entity.HasData(
				new Change
				{
					ChangeID = 1,
					ChangeType = "Add Feature",
					ChangeDescription = "Added new look to home page.",
					ChangeDate = new System.DateTime(2022, 12, 03),
					ChangeAuthor = "Ayden Masters"
				},
				new Change
				{
					ChangeID = 2,
					ChangeType = "Add Feature",
					ChangeDescription = "Added new Change Log page to the site.",
					ChangeDate = new System.DateTime(2022, 12, 03),
					ChangeAuthor = "Ayden Masters"
				},
				new Change
				{
					ChangeID = 3,
					ChangeType = "Add Feature",
					ChangeDescription = "Added new Add Application page to the site.",
					ChangeDate = new System.DateTime(2022, 12, 03),
					ChangeAuthor = "Ayden Masters"
				},
				new Change
				{
					ChangeID = 4,
					ChangeType = "Add Feature",
					ChangeDescription = "Started working on implementing the login page.",
					ChangeDate = new System.DateTime(2022, 12, 03),
					ChangeAuthor = "Ayden Masters"
				}
			);
		}
	}
}