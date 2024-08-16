using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Please Ener Your Name")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Please Ener Your Surname")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Please Ener Your User Name")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Please Ener Your Mail")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Please Ener Your Password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please Ener Your Name")]
		[Compare("Password",ErrorMessage = "Passwords do not match!")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Please Ener Your Gender")]
		public string Gender { get; set; }
		[Required(ErrorMessage = "Please Ener Your Image")]
		public string ImageUrl { get; set; }

	}
}
