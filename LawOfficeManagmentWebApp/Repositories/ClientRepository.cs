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

        public async Task<Client?> GetByIdAsync(Guid id)
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

        public async Task UpdateAsync(Client client)
        {
            var clientId = client.Id;

            _context.Clients.Update(client);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(client => client.Id == id);

            if (client == null)
            {
                throw new KeyNotFoundException($"Client with ID {id} not found.");
            }
            else
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
           
        }
    }
}
