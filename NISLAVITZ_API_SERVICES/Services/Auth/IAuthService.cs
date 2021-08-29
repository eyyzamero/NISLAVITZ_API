using System.Threading.Tasks;
using NISLAVITZ_API_SERVICES.Contracts.Requests;
using NISLAVITZ_API_SERVICES.Contracts.Responses;

namespace NISLAVITZ_API_SERVICES.Services
{
	public interface IAuthService
	{
		Task<IAuthenticateAndGetUserInfoServiceRes> AuthenticateAndGetUserInfo(IAuthenticateAndGetUserInfoServiceReq request);
	}
}
