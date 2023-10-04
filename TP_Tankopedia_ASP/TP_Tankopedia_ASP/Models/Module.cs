using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 0, ErrorMessage = "ValidationMaxMin")]
        public string Name { get; set; }
        public string TypeModule { get; set; }
        public string? imageURL { get; set; }

        [ForeignKey(nameof(Tank))]
        [Required]
        public int TankId { get; set; }
        [JsonIgnore]
        public virtual Tank Tank { get; set; }
    }
}
