using AutoMapper;
using NISLAVITZ_API_SERVICES.Models;
using NISLAVITZ_API_SERVICES.Tables;

namespace NISLAVITZ_API_SERVICES.Mappings
{
	public class UsersProfile : Profile
	{
		public UsersProfile()
		{
			CreateMap<Users, User>();
		}
	}
}
