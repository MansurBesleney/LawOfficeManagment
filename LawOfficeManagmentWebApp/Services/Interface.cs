using LawOfficeManagmentWebApp.Models.Dtos;

namespace LawOfficeManagmentWebApp.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();
        Task<ClientDto> GetClientByIdAsync(int id);
        Task CreateClientAsync(ClientDto clientDto);
    }
}
