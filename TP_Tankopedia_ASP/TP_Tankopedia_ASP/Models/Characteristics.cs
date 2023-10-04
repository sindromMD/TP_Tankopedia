using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class Characteristics
    {
        public int Id { get; set; } 
        public decimal Weight { get; set; } //tonne
        public int EnginePower { get; set; } //hp
        public int TopSpeed { get; set; } // km/h
        public decimal RateOfFire { get; set; } //tours/min
        public decimal AimingTime { get; set; } //sec
        public int AmoCapacity { get; set; } //pcs
        public decimal ReloadTime { get; set; } //sec
        public int HullArmor { get; set; } // mm

        [ForeignKey(nameof(Tank))]
        [Required]
        public int TankId { get; set; }

        [JsonIgnore]
        public virtual Tank Tank { get; set; }
    }
}
