using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NISLAVITZ_API_SERVICES.Tables
{
	[Table("Accounts")]
	public class Users
	{
		[Key]
		[Column("ID")]
		public int Id { get; set; }

		[Column("Name")]
		[StringLength(50)]
		public string Name { get; set; }

		[Column("Surname")]
		public string Surname { get; set; }

		[Column("Username")]
		[StringLength(30)]
		public string Username { get; set; }

		[Column("Password")]
		[StringLength(100)]
		public string Password { get; set; }

		[Column("Email")]
		[EmailAddress]
		[StringLength(100)]
		public string Email { get; set; }
	}
}
