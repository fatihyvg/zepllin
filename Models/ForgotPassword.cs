using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;

namespace zepllin.Models
{
    #region Şifremi Unuttum Modeli
    public class ForgotPassword : IForgotPassword
    {
        [Required(ErrorMessage = "Email Cannot Be Blank")]
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }
    }
    #endregion
}
