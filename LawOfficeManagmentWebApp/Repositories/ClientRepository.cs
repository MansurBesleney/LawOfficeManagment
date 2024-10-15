using LawOfficeManagmentWebApp.Data;
using LawOfficeManagmentWebApp.Models.Entites;
using LawOfficeManagmentWebApp.Repostories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagmentWebApp.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client?> GetByIdAsync(int id)
        {
            Client? client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                throw new KeyNotFoundException($"Client with ID {id} not found.");
            }

            return client;
            
        }

        public async Task CreateAsync(Client client)
        {
            client.Id = Guid.NewGuid();
            _context.Clients.Add(client);

            await _context.SaveChangesAsync();
        }
    }
}
