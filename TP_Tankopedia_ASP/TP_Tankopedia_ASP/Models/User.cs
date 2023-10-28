using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace TP_Tankopedia_ASP.Models
{
    public class User : IdentityUser
    {

        [JsonIgnore]
        public virtual List<Tank>? Tanks { get; set; }
    }
}
