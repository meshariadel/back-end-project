using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        public Role Role { get; set; } = Role.User;
        [EmailAddress, Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public IEnumerable<Order> orders { get; set; } // Navigation Property


    }

    public enum Role
    {
        User,
        Admin
    }
}