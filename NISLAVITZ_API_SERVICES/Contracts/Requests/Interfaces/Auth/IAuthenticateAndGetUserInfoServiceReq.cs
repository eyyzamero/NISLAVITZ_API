namespace NISLAVITZ_API_SERVICES.Contracts.Requests
{
	public interface IAuthenticateAndGetUserInfoServiceReq
	{
		string Username { get; set; }

		string Password { get; set; }
	}
}
