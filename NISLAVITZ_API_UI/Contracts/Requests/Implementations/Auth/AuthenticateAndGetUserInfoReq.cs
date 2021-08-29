using System.Collections.Generic;
using FluentValidation;
using Newtonsoft.Json;

namespace NISLAVITZ_API_UI.Contracts.Requests
{
	public class AuthenticateAndGetUserInfoReq
	{
		public string Username { get; set; }

		public string Password { get; set; }
	}

	public class AuthenticateAndGetUserInfoReqValidator : AbstractValidator<AuthenticateAndGetUserInfoReq>
	{
		public AuthenticateAndGetUserInfoReqValidator()
		{
			RuleFor(x => x.Username).NotEmpty();
			RuleFor(x => x.Password).NotEmpty();
		}
	}

	public class AuthenticateAndGetUserInfoReqErrorScheme
	{
		[JsonProperty(PropertyName = "Username")]
		public List<string> Username { get; set; }

		[JsonProperty(PropertyName = "Password")]
		public List<string> Password { get; set; }
	}
}