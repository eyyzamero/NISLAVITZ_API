using System.Collections.Generic;
using System.Reflection;

namespace NISLAVITZ_API_UI.Extensions
{
	public static class AutoMapperExtension
	{
		private static readonly List<Assembly> _assemblies = new List<Assembly>();

		public static IReadOnlyList<Assembly> GetAssemblies()
		{
			return _assemblies.AsReadOnly();
		}
	}
}
