using LawOfficeManagmentWebApp.Models.Entites;

namespace LawOfficeManagmentWebApp.Repostories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client?> GetByIdAsync(int id);
        Task CreateAsync(Client client);
    }
}
