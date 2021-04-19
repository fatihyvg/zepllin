using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;
namespace zepllin.Models
{
    #region Şifre Değiştirme Modeli
    public class ChangePassword : IChangePassword
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password Does Not Match")]
        [Display(Name = "Password Re:")]
        public string ConfirmPassword
        {
            get;
            set;
        }
        public string Token
        {
            get;
            set;
        }
    }
    #endregion
}
