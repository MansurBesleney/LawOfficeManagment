using AutoMapper;
using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Models.Entites;
using LawOfficeManagementWebApp.Repositories;

namespace LawOfficeManagementWebApp.Services
{
    public class LawyerService : ILawyerService
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly IMapper _mapper;

        public LawyerService(ILawyerRepository lawyerRepository, IMapper mapper)
        {
            _lawyerRepository = lawyerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LawyerDto>> GetAllLawyersAsync()
        {
            var lawyers = await _lawyerRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<LawyerDto>>(lawyers);
        }

        public async Task<LawyerDto> GetLawyerByIdAsync(Guid id)
        {
            var lawyer = await _lawyerRepository.GetByIdAsync(id);

            return _mapper.Map<LawyerDto>(lawyer);
        }

        public async Task CreateLawyerAsync(LawyerDto lawyerDto)
        {
            var lawyer = _mapper.Map<Lawyer>(lawyerDto);

            await _lawyerRepository.CreateAsync(lawyer);
        }

        public async Task UpdateLawyerAsync(LawyerDto lawyerDto)
        {
            var lawyer = _mapper.Map<Lawyer>(lawyerDto);

            await _lawyerRepository.UpdateAsync(lawyer);
        }

        public async Task DeleteLawyerAsync(Guid id)
        {
            await _lawyerRepository.DeleteAsync(id);
        }
    }
}
