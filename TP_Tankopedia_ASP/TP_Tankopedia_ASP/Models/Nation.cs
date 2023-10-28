using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class Nation
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 0, ErrorMessage = "ValidationMaxMin")]
        public string Name { get; set; }
        public string? ImageURL { get; set; }

        [JsonIgnore]
        public virtual List<Tank>? Tanks { get; set; }

        [ForeignKey(nameof(Picture))]
        public int? pictureId { get; set; }
        [JsonIgnore]
        public virtual Picture? Picture { get; set; }
    }
}
