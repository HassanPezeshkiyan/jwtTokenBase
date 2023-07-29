using System.ComponentModel.DataAnnotations;

namespace JWT_RefreshToken.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "فیلد نام کاربری الزامی است")]
        public string?  Username { get; set; }
        
        
        [Required(ErrorMessage = "فیلد رمزعبو الزامی است")]
        public string?  Password { get; set; }
    }
}
