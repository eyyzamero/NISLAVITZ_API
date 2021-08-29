using System.Threading.Tasks;
using NISLAVITZ_API_SERVICES.Models;

namespace NISLAVITZ_API_SERVICES.Services
{
	public interface IUsersService
	{
		Task<User> GetUserByID(int userID);

		Task<User> GetUserByUsernameAndPassword(string username, string password);
	}
}
