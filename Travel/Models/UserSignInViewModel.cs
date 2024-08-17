using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Please Enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Passowrd")]
        public string Password { get; set; }
    }
}
