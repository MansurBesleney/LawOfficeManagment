using LawOfficeManagementWebApp.Data;
using LawOfficeManagementWebApp.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagementWebApp.Repositories
{
    public class LawyerRepository : ILawyerRepository
    {
        private readonly ApplicationDbContext _context;

        public LawyerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lawyer>> GetAllAsync()
        {
            return await _context.Lawyers
                    .Include(c => c.Clients)
                    .ToListAsync();
        }

        public async Task<Lawyer?> GetByIdAsync(Guid id)
        {
            var lawyer = await _context.Lawyers
                            .Include(c => c.Clients)
                            .FirstOrDefaultAsync(c => c.Id == id);

            if(lawyer == null)
            {
                throw new KeyNotFoundException($"Lawyer with ID {id} not found.");
            }

            return lawyer;
        }

        public async Task CreateAsync(Lawyer lawyer)
        {
            lawyer.Id = Guid.NewGuid();

            await _context.Lawyers.AddAsync(lawyer);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Lawyer lawyer)
        {
            var lawyerId = lawyer.Id;

            _context.Lawyers.Update(lawyer);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var lawyer = await _context.Lawyers.FirstOrDefaultAsync(lawyer => lawyer.Id == id);
        
            if(lawyer == null)
            {
                throw new KeyNotFoundException($"Lawyer with ID {id} could not found");
            }
            else
            {
                _context.Lawyers.Remove(lawyer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
