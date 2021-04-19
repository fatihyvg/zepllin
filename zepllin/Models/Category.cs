using System.ComponentModel.DataAnnotations;
using zepllin.Interfaces;
namespace zepllin.Models
{
    #region Kategori Modeli
    public class Category : ICategory
    {
        [Key]
        public int CategoryId
        {
            get;
            set;
        }
        public string CategoryName
        {
            get;
            set;
        }
    }
    #endregion
}
