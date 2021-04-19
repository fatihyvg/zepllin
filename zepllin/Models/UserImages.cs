using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zepllin.Interfaces;
namespace zepllin.Models
{
    public class UserImages : IUserImages
    {
        [Key]
        public int ImageId
        {
            get;
            set; 
        }
        public int UserNormalId
        {
            get;
            set;
        }
        public int ImageApprove 
        {
            get;
            set;
        }
        public int ImageEdıtor
        {
            get;
            set;
        }
        [ForeignKey("category_fk")]
        public int ImageCategoryFk
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public string ImageNewNumber
        {
            get;
            set;
        }
        public string ImageTitle
        {
            get;
            set;
        }
        public string ImageWithoutSeoTitle
        {
            get;
            set;
        }
        public string ImageSrc
        {
            get;
            set;
        }
        public string ImageExifFNumber
        {
            get;
            set;
        }
        public string ImageExifFocalLength
        {
            get;
            set;
        }
        public string ImageExifLensModel
        {
            get;
            set;
        }
        public string ImageExifMeteringMode
        {
            get;
            set;
        }
        public string ImageExifModel
        {
            get;
            set;
        }
        public string ImageExifShutterSpeedValue
        {
            get;
            set;
        }
        public string ImageExifExposureMode
        {
            get;
            set;
        }
        public string ImageExifExposureProgram
        {
            get;
            set;
        }
        public string ImageExifExposureTime
        {
            get;
            set;
        }
        public string ImageExifMake
        {
            get;
            set;
        }
        public string ImageExifIso
        {
            get;
            set;
        }
    }
}
