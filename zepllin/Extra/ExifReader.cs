using System.IO;
using ExifLibrary;
namespace zepllin.Extra
{
    public class ExifReader
    {
        #region
        /*TODO exif bilgileri*/
        public ExifReader(Stream streamread)
        {
            ImageFile img = ImageFile.FromStream(streamread);
            if (img.Properties.Get<ExifURational>(ExifTag.FNumber) != null)
            {
                ExifFNumber = img.Properties.Get<ExifURational>(ExifTag.FNumber).ToFloat();
                ExifFocalLength = img.Properties.Get<ExifProperty>(ExifTag.FocalLength);
                ExifLensModel = img.Properties.Get<ExifProperty>(ExifTag.LensModel);
                ExifMeteringMode = img.Properties.Get<ExifProperty>(ExifTag.MeteringMode);
                ExifModel = img.Properties.Get<ExifProperty>(ExifTag.Model);
                ExifShutterSpeedValue = img.Properties.Get<ExifProperty>(ExifTag.ShutterSpeedValue);
                ExifExposureMode = img.Properties.Get<ExifProperty>(ExifTag.ExposureMode);
                ExifExposureProgram = img.Properties.Get<ExifProperty>(ExifTag.ExposureProgram);
                ExifExposureTime = img.Properties.Get<ExifProperty>(ExifTag.ExposureTime);
                ExifMake = img.Properties.Get<ExifProperty>(ExifTag.Make);
                ExifIso = img.Properties.Get<ExifProperty>(ExifTag.ISOSpeedRatings);
           }
        }
        public float? ExifFNumber
        {
            get;
            private set;
        }
        public object ExifFocalLength
        {
           get;
           private set;
        }
        public object ExifLensModel
        {
           get;
           private set;
        }
        public object ExifMeteringMode
        {
           get;
           private set;
        }
        public object ExifModel
        {
           get;
           private set;
        }
        public object ExifShutterSpeedValue
        {
           get;
           private set;
        }
        public object ExifExposureMode
        {
           get;
           private  set;
        }
        public object ExifExposureProgram
        {
            get;
            private set;
        }
        public object ExifExposureTime
        {
            get;
            private set;
        }
        public object ExifMake
        {
            get;
            private set;
        }
        public object ExifIso
        {
            get;
            private set;
        }
    }
    #endregion
}
