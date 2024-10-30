using LawOfficeManagementWebApp.Models.Entites;

namespace LawOfficeManagementWebApp.Repostories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client?> GetByIdAsync(Guid id);
        Task CreateAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(Guid id);
    }
}
