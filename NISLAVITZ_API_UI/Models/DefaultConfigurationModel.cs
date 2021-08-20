﻿namespace NISLAVITZ_API_UI.Models
{
	public class DefaultConfigurationModel
	{
		public bool AutoMapperEnabled { get; set; } = false;

		public bool UseAPIConfiguration { get; set; } = false;

		public bool SwaggerEnabled { get; set; } = false;

		public bool DefaultCorsPolicy { get; set; } = false;

		public bool LogsEnabled { get; set; } = false;
	}
}
