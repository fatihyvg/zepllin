namespace zepllin.Interfaces
{
    public interface IUserImages
    {
        int ImageId
        {
            get;
            set;
        }
        int UserNormalId
        {
            get;
            set;
        }
        int ImageApprove
        {
            get;
            set;
        }
        int ImageEdıtor
        {
            get;
            set;
        }
        int ImageCategoryFk
        {
            get;
            set;
        }
        string UserName
        {
            get;
            set;
        }
        string UserEmail
        {
            get;
            set;
        }
        string ImageNewNumber
        {
            get;
            set;
        }
        string ImageTitle
        {
            get;
            set;
        }
        string ImageWithoutSeoTitle
        {
            get;
            set;
        }
        string ImageSrc
        {
            get;
            set;
        }
        string ImageExifFNumber
        {
            get;
            set;
        }
        string ImageExifFocalLength
        {
            get;
            set;
        }
        string ImageExifLensModel
        {
            get;
            set;
        }
        string ImageExifMeteringMode
        {
            get;
            set;
        }
        string ImageExifModel
        {
            get;
            set;
        }
        string ImageExifShutterSpeedValue
        {
            get;
            set;
        }
        string ImageExifExposureMode
        {
            get;
            set;
        }
        string ImageExifExposureProgram
        {
            get;
            set;
        }
        string ImageExifExposureTime
        {
            get;
            set;
        }
        string ImageExifMake
        {
            get;
            set;
        }
        string ImageExifIso
        {
            get;
            set;
        }
    }
}
