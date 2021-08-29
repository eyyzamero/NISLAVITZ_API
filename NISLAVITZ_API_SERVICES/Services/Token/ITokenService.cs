using NISLAVITZ_API_SERVICES.Models;

namespace NISLAVITZ_API_SERVICES.Services
{
	public interface ITokenService
	{
		string GenerateJWTToken(User user);
	}
}
