using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class Tank
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "ValidationMaxMin")]
        public string Name { get; set; }
        [Required]
        [StringLength(2500, MinimumLength = 10, ErrorMessage = "ValidationMaxMin")]
        public string Description { get; set; }
        public int? YearOfCreation { get; set; }
        public string? ImageURL { get; set; }

        [ForeignKey(nameof(Nation))]
        [Required]
        public int NationID { get; set; }

        [JsonIgnore]
        public virtual Nation? Nation { get; set; }

        [JsonIgnore]
        public virtual List<TankModule>? TankModules { get; set; }

        [ForeignKey(nameof(TypeTank))]
        [Required]
        public int TypeID { get; set; }

        [JsonIgnore]
        public virtual TypeTank? TypeTank { get; set; }

        [ForeignKey(nameof(StrategicRole))]
        [Required]
        public int StrategicRoleId { get; set; }

        [JsonIgnore]
        public virtual StrategicRole? StrategicRole { get; set; }

        [JsonIgnore]
        public virtual Characteristics? Characteristics { get; set; }
    }
}
