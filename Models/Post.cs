using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tiny_Social_Media.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationship to the User
        public string UserId { get; set; } = string.Empty;
        public IdentityUser? User { get; set; }
    }
}
