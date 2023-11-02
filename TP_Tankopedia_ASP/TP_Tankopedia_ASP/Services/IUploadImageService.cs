using TP_Tankopedia_ASP.Models;

namespace TP_Tankopedia_ASP.Services
{
    public interface IUploadImageService
    {
        void ConvertPicture(Image originalImage, Picture picture);
    }
}
