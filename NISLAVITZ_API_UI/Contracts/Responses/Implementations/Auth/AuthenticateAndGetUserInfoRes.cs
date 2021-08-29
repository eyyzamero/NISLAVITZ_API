using NISLAVITZ_API_SERVICES.Models;

namespace NISLAVITZ_API_UI.Contracts.Responses
{
	public class AuthenticateAndGetUserInfoRes
	{
		public User User { get; set; }

		public string Token { get; set; }
	}
}
