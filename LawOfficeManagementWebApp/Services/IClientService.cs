using LawOfficeManagementWebApp.Models.Dtos;

namespace LawOfficeManagementWebApp.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();
        Task<ClientDto> GetClientByIdAsync(Guid id);
        Task CreateClientAsync(ClientDto clientDto);
        Task UpdateClientAsync(ClientDto clientDto);
        Task DeleteClientAsync(Guid id);
    }
}