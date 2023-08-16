using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Models
{
    public class User
    {
        [Key]
        public int Userid { get; set; }

        [Required]      
        public string Username { get; set; }

        [Required]  
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
