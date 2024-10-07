using LawOfficeManagmentWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagmentWebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
