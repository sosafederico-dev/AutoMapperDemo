using AutoMapper;
using AutoMapperDemo.Repositories;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.Services
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

        public async Task<ClientViewModel> GetClient()
        {
            var client = await _clientRepository.GetClient();

            // Without AutoMapper
            //var clientViewModel = new ClientViewModel()
            //{
            //    ClientId = client.ClientId,
            //    FirstName = client.FirstName,
            //    LastName = client.LastName,
            //    Email = client.Email,
            //    Phone = client.Phone
            //};

            // With AutoMapper
            var clientViewModel = _mapper.Map<ClientViewModel>(client);

            return clientViewModel;
        }
    }
}
