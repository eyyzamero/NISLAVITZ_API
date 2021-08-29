using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NISLAVITZ_API_SERVICES.Contexts;
using NISLAVITZ_API_SERVICES.Models;
using NISLAVITZ_API_SERVICES.Tables;

namespace NISLAVITZ_API_SERVICES.Services
{
	public class UsersService : IUsersService
	{
		private readonly IMapper _mapper;
		private readonly UsersContext _usersContext;

		public UsersService(IConfiguration config, IMapper mapper)
		{
			_mapper = mapper;

			var configEnumerable = config.AsEnumerable();
			var connectionString = configEnumerable.FirstOrDefault(item => item.Key == "connectionString").Value;

			if (string.IsNullOrWhiteSpace(connectionString)) return;

			var optionsBuilder = new DbContextOptionsBuilder<UsersContext>();
			optionsBuilder.UseSqlServer(connectionString);
			optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
			_usersContext = new UsersContext(optionsBuilder.Options);
		}
		
		public async Task<User> GetUserByID(int userID)
		{
			var user = await _usersContext.Users.SingleOrDefaultAsync(x => x.Id == userID);

			if (user == null) return null;

			var mappedResponse = _mapper.Map<Users, User>(user);
			return mappedResponse;
		}

		public async Task<User> GetUserByUsernameAndPassword(string username, string password)
		{
			var user = await _usersContext.Users.SingleOrDefaultAsync(x => x.Username == username && x.Password == password);

			if (user == null) return null;

			var mappedResponse = _mapper.Map<Users, User>(user);
			return mappedResponse;
		}
	}
}
