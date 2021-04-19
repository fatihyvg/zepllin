using zepllin.Interfaces;
using System.ComponentModel.DataAnnotations;
namespace zepllin.Models
{
    public class AdminLogin : IAdminLogin
    {
        #region
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
        
        #endregion
    }
}
