using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NISLAVITZ_API_SERVICES.Contracts.Requests;
using NISLAVITZ_API_SERVICES.Contracts.Responses;

namespace NISLAVITZ_API_SERVICES.Services
{
	public class AuthService : IAuthService
	{
		private readonly ITokenService _tokenService;
		private readonly IUsersService _usersService;
		
		public AuthService(IConfiguration config, ITokenService tokenService, IUsersService usersService)
		{
			_tokenService = tokenService;
			_usersService = usersService;
		}

		public async Task<IAuthenticateAndGetUserInfoServiceRes> AuthenticateAndGetUserInfo(IAuthenticateAndGetUserInfoServiceReq request)
		{
			var user = await _usersService.GetUserByUsernameAndPassword(request.Username, request.Password);

			if (user == null) return null;

			var token = _tokenService.GenerateJWTToken(user);
			var serviceResponse = new AuthenticateAndGetUserInfoServiceRes
			{
				User = user,
				Token = token
			};
			return serviceResponse;
		}
	}
}
