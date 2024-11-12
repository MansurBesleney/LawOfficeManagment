using LawOfficeManagementWebApp.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagementWebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(client => client.Id)
                .IsClustered(false);

            modelBuilder.Entity<Lawyer>()
                .HasKey(lawyer => lawyer.Id)
                .IsClustered(false);
        }


    }
}
