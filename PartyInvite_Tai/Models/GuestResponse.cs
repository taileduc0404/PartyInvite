using System.ComponentModel.DataAnnotations;

namespace PartyInvite_Tai.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage ="Please enter your name!")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Please enter your email!")]
		[RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter you phone number")]
		public string? Email { get; set; }
		public int Phone { get; set; }
		[Required(ErrorMessage = "Please specify whether you'll attend!")]
		public bool? WillAttend { get; set; }
	}
}
