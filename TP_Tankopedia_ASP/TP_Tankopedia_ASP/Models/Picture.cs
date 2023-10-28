using System.ComponentModel.DataAnnotations;

namespace TP_Tankopedia_ASP.Models
{
    public class Picture
    {
        [Key]
        public int pictureId { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public DateTime DateOfAddition { get; set; }
    }
}
