using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;
namespace zepllin.Models
{
    #region
    public class NormalLogin : INormalLogin
    {
        [Required(ErrorMessage = "User Name Wrong")]
        public string UserName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Password Wrong")]
        public string UserPassword
        {
            get;
            set;
        }
    }
    #endregion
}
