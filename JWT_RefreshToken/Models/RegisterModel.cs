using System.ComponentModel.DataAnnotations;

namespace JWT_RefreshToken.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "فیلد نام کاربری الزامی است")]
        public string? Username { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "فیلد ایمیل الزامی است")]
        public string? Email { get; set; }
        
        
        [Required(ErrorMessage = "فیلد رمزعبور الزامی است")]
        public string? Password{ get; set; }
    }
}
