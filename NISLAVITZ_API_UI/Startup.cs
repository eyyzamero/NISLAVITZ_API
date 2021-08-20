using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NISLAVITZ_API_UI.Extensions;
using NISLAVITZ_API_UI.Models;

namespace NISLAVITZ_API_UI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			ServiceRegistration(services);
			EntityFrameworkDBConnection(services);
			HttpClientsRegistration(services);

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
			services.AddControllers();

			services.AddDefaultConfiguration<Startup>(new DefaultConfigurationModel()
			{
				AutoMapperEnabled = true,
				UseAPIConfiguration = true,
				SwaggerEnabled = true,
				DefaultCorsPolicy = true,
				LogsEnabled = true
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			app.AddDefaultConfiguration();
		}

		public static void ServiceRegistration(IServiceCollection services)
		{
			
		}

		public static void EntityFrameworkDBConnection(IServiceCollection services)
		{
			
		}

		public static void HttpClientsRegistration(IServiceCollection services)
		{
			services.AddHttpClient("default", config =>
			{
				config.DefaultRequestHeaders.Add("Accept", "text/plain");
			});
		}
	}
}
