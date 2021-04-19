using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;
namespace zepllin.Models
{
    #region Normal Kullanıcı Modeli
    public class NormalUser : INormalUser
    {
        public string UserId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "User Name Wrong")]
        public string UserName
        {
            get;
            set;
        }
        [EmailAddress]
        [Required(ErrorMessage = "Email Wrong")]
        public string Email
        {
            get;
            set;
        }
        [MinLength(8)]
        [Required(ErrorMessage = "Password Wrong")]
        public string UserPassword
        {
            get;
            set;
        }
    }
    #endregion
}
