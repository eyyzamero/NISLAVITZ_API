using NISLAVITZ_API_SERVICES.Models;

namespace NISLAVITZ_API_SERVICES.Contracts.Responses
{
	public interface IAuthenticateAndGetUserInfoServiceRes
	{
		User User { get; set; }

		string Token { get; set; }
	}
}
