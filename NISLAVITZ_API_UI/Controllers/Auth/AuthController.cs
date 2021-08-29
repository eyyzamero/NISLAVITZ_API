using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NISLAVITZ_API_SERVICES.Contracts.Requests;
using NISLAVITZ_API_SERVICES.Services;
using NISLAVITZ_API_UI.Contracts.Requests;
using NISLAVITZ_API_UI.Contracts.Responses;

namespace NISLAVITZ_API_UI.Controllers
{
	[ApiController]
	[Produces("application/json")]
	public class AuthController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IAuthService _authService;
		
		public AuthController(IMapper mapper, IAuthService authService)
		{
			_mapper = mapper;
			_authService = authService;
		}

		[HttpPost]
		[Route("AuthenticateAndGetUserInfo")]
		[ProducesResponseType(typeof(AuthenticateAndGetUserInfoReqErrorScheme), (int) HttpStatusCode.BadRequest)]
		public async Task<ActionResult<AuthenticateAndGetUserInfoRes>> AuthenticateAndGetUserInfo(AuthenticateAndGetUserInfoReq request)
		{
			var serviceRequest = _mapper.Map<IAuthenticateAndGetUserInfoServiceReq>(request);
			var serviceResponse = await _authService.AuthenticateAndGetUserInfo(serviceRequest);

			if (serviceResponse == null) 
				return Unauthorized();

			var response = _mapper.Map<AuthenticateAndGetUserInfoRes>(serviceResponse);
			return response;
		}

		[HttpGet]
		[Route("RevokeToken")]
		public async Task<ActionResult<bool>> RevokeToken()
		{
			return Ok(new { Success = true });
		}
	}
}
