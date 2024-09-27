using System.ComponentModel.DataAnnotations;

namespace LawOfficeManagmentWebApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Müvekkilin 11 haneli TC kimlik numarasını girdiğinizden emin olunuz.")]
        public string ClientTcNumber { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekkilin adını girdiğinizden emin olunuz.")]
        public string ClientName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekiilin soyadını girdiğinizden emin olunuz.")]
        public string ClientSurname { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Müvekkilin telefon numarasını girdiğinizden emin olunuz.")]
        public string ClientGSM { get; set; } = null!;

    }
}
