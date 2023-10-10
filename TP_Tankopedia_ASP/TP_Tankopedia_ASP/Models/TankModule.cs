using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class TankModule
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 0, ErrorMessage = "ValidationMaxMin")]
        public string Name { get; set; }
        public string TypeModule { get; set; }  //Normalement, les types de modules auraient été définis par une classe TypeModule, mais on se limite aux chaînes de caractères pour ce projet.
        public string? imageURL { get; set; }

        [ForeignKey(nameof(Tank))]
        [Required]
        public int TankId { get; set; }
        [JsonIgnore]
        public virtual Tank Tank { get; set; }
    }
}
