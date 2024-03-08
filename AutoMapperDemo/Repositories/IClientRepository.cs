using AutoMapperDemo.Models;

namespace AutoMapperDemo.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetClient();
    }
}
