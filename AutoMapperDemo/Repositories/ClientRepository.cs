using AutoMapperDemo.Models;

namespace AutoMapperDemo.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public async Task<Client> GetClient()
        {
            return new Client()
            {
                ClientId = 1,
                FirstName = "Robert",
                LastName = "Plant",
                Email = "plant@gmail.com",
                Phone = "02745891",
                Address = new Address
                {
                    Street = "Palo Alto",
                    Number = 9,
                    City = "San Francisco"
                }
            };
        }
    }
}
