using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    // this is a comment to test the git connection
    public class AppUser
    {
        [Required]
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 6)]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}