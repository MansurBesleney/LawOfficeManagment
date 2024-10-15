using LawOfficeManagmentWebApp.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagmentWebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(client => client.Id)
                .IsClustered(false);
        }

        
    }
}
