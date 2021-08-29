using System.Threading.Tasks;
using NISLAVITZ_API_SERVICES.Contracts.Requests;
using NISLAVITZ_API_SERVICES.Contracts.Responses;

namespace NISLAVITZ_API_SERVICES.Services
{
	public class AuthService : IAuthService
	{
		public AuthService()
		{

		}

		public async Task<IAuthenticateAndGetUserInfoServiceRes> AuthenticateAndGetUserInfo(IAuthenticateAndGetUserInfoServiceReq request)
		{
			return new AuthenticateAndGetUserInfoServiceRes();
		}
	}
}
