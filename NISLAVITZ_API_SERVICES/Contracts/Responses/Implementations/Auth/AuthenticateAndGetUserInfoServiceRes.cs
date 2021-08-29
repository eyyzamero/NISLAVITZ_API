using NISLAVITZ_API_SERVICES.Models;

namespace NISLAVITZ_API_SERVICES.Contracts.Responses
{
	public class AuthenticateAndGetUserInfoServiceRes : IAuthenticateAndGetUserInfoServiceRes
	{
		public User User { get; set; }

		public string Token { get; set; }
	}
}
