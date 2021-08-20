using Microsoft.AspNetCore.Builder;

namespace NISLAVITZ_API_UI.Extensions
{
	public static class ApplicationBuilderExtension
	{
		public static IApplicationBuilder AddDefaultConfiguration(this IApplicationBuilder app)
		{
			if (ServiceCollectionExtension.UsingSwagger)
			{
				app.UseSwagger(config =>
				{
					config.SerializeAsV2 = true;
				});
				app.UseSwaggerUI(config =>
				{
					config.DefaultModelsExpandDepth(-1);
					config.SwaggerEndpoint("/swagger/v1/swagger.json", "NISLAVITZ_API");
				});
			}

			if (ServiceCollectionExtension.UsingDefaultCorsPolicy)
				app.UseCors(ServiceCollectionExtension.NameOfCorsPolicy);

			return app;
		}
	}
}
