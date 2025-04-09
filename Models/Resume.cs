using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Models
{
    public class Resume
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; } = string.Empty;
        
        public string? Summary { get; set; }
        public string? Education { get; set; }
        public string? Experience { get; set; }
        public string? Skills { get; set; }
    }
}