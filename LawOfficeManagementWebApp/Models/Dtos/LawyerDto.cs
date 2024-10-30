using System.ComponentModel.DataAnnotations;

namespace LawOfficeManagementWebApp.Models.Dtos;

public class LawyerDto
{
    public Guid Id { get; set; } = Guid.Empty;
    
    [Required(ErrorMessage = "Sicil numarası girilmesi zorunludur.")]
    [StringLength(5, MinimumLength = 5, ErrorMessage = "Geçerli sicil numarası giriniz!")]
    public string RegistrationNumber { get; set; } = null!;
    [Required(ErrorMessage = "Ad girilmesi zorunludur.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Geçerli bir ad giriniz.")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Soyad girilmesi zorunludur.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Geçerli bir soyad giriniz.")]
    public string LastName { get; set; } = null!;
    [Required(ErrorMessage = "Avukatın E-posta adresi girilmelidir.")]
    [EmailAddress(ErrorMessage = "Geçersiz E-posta adresi!")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Telefon numarası girilmelidir.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
    public string Gsm { get; set; } = null!;
    public List<ClientDto> Clients { get; set; } = null!;

    
}