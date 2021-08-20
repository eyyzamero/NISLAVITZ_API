using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NISLAVITZ_API_UI.Controllers
{
	[ApiController]
	[Produces("application/json")]
	public class AuthController : ControllerBase
	{
		[HttpPost]
		[Route("GetToken")]
		public async Task<ActionResult<bool>> GetToken()
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
