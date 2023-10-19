using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class Characteristics
    {
        public int Id { get; set; }
        [Required]
        public decimal Weight { get; set; } //tonne
        [Required]
        public int EnginePower { get; set; } //hp
        [Required]
        public int TopSpeed { get; set; } // km/h
        [Required]
        public decimal RateOfFire { get; set; } //tours/min
        [Required]
        public decimal AimingTime { get; set; } //sec
        [Required]
        public int AmoCapacity { get; set; } //pcs
        [Required]
        public decimal ReloadTime { get; set; } //sec
        [Required]
        public int HullArmor { get; set; } // mm

        [ForeignKey(nameof(Tank))]
        [Required]
        public int TankId { get; set; }

        [JsonIgnore]
        public virtual Tank? Tank { get; set; }
    }
}
