using System.ComponentModel.DataAnnotations;

namespace TP_Tankopedia_ASP.Models
{
    public class LoginDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
