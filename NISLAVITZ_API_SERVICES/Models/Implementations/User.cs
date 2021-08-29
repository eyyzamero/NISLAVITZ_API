using Newtonsoft.Json;

namespace NISLAVITZ_API_SERVICES.Models
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Username { get; set; }

		[JsonIgnore]
		public string Password { get; set; }

		public string Email { get; set; }
	}
}
