using System.ComponentModel.DataAnnotations;

namespace Passel.Models
{
	public class Account
	{
		public int AccountID { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}