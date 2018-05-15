using System.ComponentModel.DataAnnotations;

namespace ConsultancyBridge.ViewModel
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}