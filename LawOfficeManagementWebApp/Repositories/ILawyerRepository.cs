using LawOfficeManagementWebApp.Models.Entites;

namespace LawOfficeManagementWebApp.Repositories
{
    public interface ILawyerRepository
    {
        Task<IEnumerable<Lawyer>> GetAllAsync();
        Task<Lawyer?> GetByIdAsync(Guid id);
        Task CreateAsync(Lawyer lawyer);
        Task UpdateAsync(Lawyer lawyer);
        Task DeleteAsync(Guid id);
    }
}
