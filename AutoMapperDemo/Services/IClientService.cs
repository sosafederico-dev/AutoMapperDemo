using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.Services
{
    public interface IClientService
    {
        Task<ClientViewModel> GetClient();
    }
}
