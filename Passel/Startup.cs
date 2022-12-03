using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Passel.Models;

namespace Passel
{
	public class Startup
	{

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRouting(options => options.LowercaseUrls = true);

			services.AddMemoryCache();
			services.AddSession();

			services.AddControllersWithViews().AddNewtonsoftJson();

			services.AddDbContext<PasselContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("PasselContext")));
		}

		// Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app)
		{
			app.UseDeveloperExceptionPage();
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSession();

			app.UseEndpoints(endpoints =>
			{
				// default route
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
			});
		}
	}
}