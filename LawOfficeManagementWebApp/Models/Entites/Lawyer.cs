namespace LawOfficeManagementWebApp.Models.Entites
{
    public class Lawyer
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gsm { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Client> Clients { get; set; } = null!;
    }
}
