using System.ComponentModel.DataAnnotations;

namespace LawOfficeManagmentWebApp.Models.Dtos
{
    public class ClientDto
    {

        public Guid Id { get; set; } = Guid.Empty;
        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Müvekkilin 11 haneli TC kimlik numarasını girdiğinizden emin olunuz.")]
        public string TcNumber { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekkilin adını girdiğinizden emin olunuz.")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekiilin soyadını girdiğinizden emin olunuz.")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekkilin telefon numarasını girdiğinizden emin olunuz.")]
        public string Gsm { get; set; } = null!;
    }
}
