using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;
namespace zepllin.Models
{
    public class RefreshPassword : IRefreshPassword
    {

        [Required]
        [DataType(DataType.Password)]
        public string OldPassword
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string NewPassword
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Error")]
        [Display(Name = "RePassword")]
        public string RePassword
        {
            get;
            set;
        }
    }
}
