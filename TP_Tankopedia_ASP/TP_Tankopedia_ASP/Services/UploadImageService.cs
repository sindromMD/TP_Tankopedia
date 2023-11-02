using TP_Tankopedia_ASP.Models;

namespace TP_Tankopedia_ASP.Services
{
    public class UploadImageService : IUploadImageService
    {
        public void ConvertPicture(Image originalImage, Picture picture)
        {
            // Enregistrer l'image originale dans le dossier "original".
            originalImage.Save(Directory.GetCurrentDirectory() + "/images/original/" + picture.FileName);

            // Créer une copie de l'image à redimensionner(large)
            Image lgImage = originalImage;
            // Redimensionne l'image - large
            lgImage.Mutate(i =>
                i.Resize(new ResizeOptions()
                {
                    Mode = ResizeMode.Min,
                    Size = new Size() { Height = 300 }
                })
                );
            // Enregistrer une large image dans le dossier "lg"
            lgImage.Save(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);

            // Créer une copie de l'image à redimensionner(small)
            Image smImage = lgImage;
            // Redimensionne la petite image
            smImage.Mutate(i =>
                i.Resize(new ResizeOptions()
                {
                    Mode = ResizeMode.Min,
                    Size = new Size() { Height = 150 }
                })
                );
            // Enregistrer la petite image dans le dossier "sm".
            smImage.Save(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);
        }
    }
}
