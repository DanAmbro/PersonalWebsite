using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Message { get; set; } = null!;

       
    }
}
