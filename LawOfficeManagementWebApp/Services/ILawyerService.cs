
using LawOfficeManagementWebApp.Models.Dtos;

namespace LawOfficeManagementWebApp.Services
{
    public interface ILawyerService
    {
        Task<IEnumerable<LawyerDto>> GetAllLawyersAsync();
        Task<LawyerDto> GetLawyerByIdAsync(Guid id);
        Task CreateLawyerAsync(LawyerDto lawyerDto);
        Task UpdateLawyerAsync(LawyerDto lawyerDto);
        Task DeleteLawyerAsync(Guid id);
    }
}
