using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Passel.Models
{
	internal class SeedMedias : IEntityTypeConfiguration<Media>
	{
		public void Configure(EntityTypeBuilder<Media> entity)
		{
			entity.HasData(
				new Media
				{
					MediaID = 1,
					MediaType = "Entertainment",
					MediaName = "YouTube",
					MediaURL = "https://www.youtube.com/"
				},
				new Media
				{
					MediaID = 2,
					MediaType = "Entertainment",
					MediaName = "Netflix",
					MediaURL = "https://www.netflix.com/"
				},
				new Media
				{
					MediaID = 3,
					MediaType = "Entertainment",
					MediaName = "Hulu",
					MediaURL = "https://www.hulu.com/"
				},
				new Media
				{
					MediaID = 4,
					MediaType = "Social Media",
					MediaName = "Twitter",
					MediaURL = "https://twitter.com/"
				},
				new Media
				{
					MediaID = 5,
					MediaType = "Social Media",
					MediaName = "Facebook",
					MediaURL = "https://www.facebook.com/"
				},
				new Media
				{
					MediaID = 6,
					MediaType = "Social Media",
					MediaName = "Reddit",
					MediaURL = "https://www.reddit.com/"
				}
			);
		}
	}
}