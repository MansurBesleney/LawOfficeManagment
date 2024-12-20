﻿using AutoMapper;
using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Models.Entites;
using LawOfficeManagementWebApp.Repostories;

namespace LawOfficeManagementWebApp.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
        {
            var clients = await _clientRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ClientDto>>(clients);
        }

        public async Task<ClientDto> GetClientByIdAsync(Guid id)
        {
            var client = await _clientRepository.GetByIdAsync(id);

            return _mapper.Map<ClientDto>(client);
        }

        public async Task CreateClientAsync(ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);

            await _clientRepository.CreateAsync(client);
        }

        public async Task UpdateClientAsync(ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);

            await _clientRepository.UpdateAsync(client);
        }

        public async Task DeleteClientAsync(Guid id)
        {
           await _clientRepository.DeleteAsync(id);
        }
    }
}
