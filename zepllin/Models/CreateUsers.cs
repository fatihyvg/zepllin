using Microsoft.AspNetCore.Identity;

namespace zepllin.Models
{
    #region Kullanıcı Oluşturma Modeli
    public class CreateUsers : IdentityUser
    {
        public string Name
        {
            get;
            set;
        }
        public string SurName
        {
            get;
            set;
        }
      #endregion
    }
}
