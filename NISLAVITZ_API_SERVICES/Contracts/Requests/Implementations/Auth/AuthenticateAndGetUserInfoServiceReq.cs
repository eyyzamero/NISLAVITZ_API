namespace NISLAVITZ_API_SERVICES.Contracts.Requests
{
	public class AuthenticateAndGetUserInfoServiceReq : IAuthenticateAndGetUserInfoServiceReq
	{
		public string Username { get; set; }

		public string Password { get; set; }
	}
}
