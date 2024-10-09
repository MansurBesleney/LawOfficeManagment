using System.ComponentModel.DataAnnotations;

namespace LawOfficeManagmentWebApp.Models.Entites
{
    public class Client
    {
        public Guid Id { get; set; }

        public string TcNumber { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Gsm { get; set; } = null!;

    }
}
