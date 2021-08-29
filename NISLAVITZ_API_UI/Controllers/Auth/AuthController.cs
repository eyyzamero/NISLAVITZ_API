using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NISLAVITZ_API_UI.Contracts.Requests;

namespace NISLAVITZ_API_UI.Controllers
{
	[ApiController]
	[Produces("application/json")]
	public class AuthController : ControllerBase
	{
		[HttpPost]
		[Route("AuthenticateAndGetUserInfo")]
		[ProducesResponseType(typeof(AuthenticateAndGetUserInfoReqErrorScheme), (int) HttpStatusCode.BadRequest)]
		public async Task<ActionResult<bool>> AuthenticateAndGetUserInfo()
		{
			return Ok(new { Success = true });
		}

		[HttpGet]
		[Route("RevokeToken")]
		public async Task<ActionResult<bool>> RevokeToken()
		{
			return Ok(new { Success = true });
		}
	}
}
