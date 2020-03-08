using Core.Abstractions;
using Core.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ClientService : IAddClientService
    {
        private readonly IMedContext _medContext;
        public ClientService(IMedContext medContext)
        {
            _medContext = medContext;
        }

        public IEnumerable<ClientCart> GetClients()
        {
            return _medContext.GetAllClients();
        }

        public void GetClients(ClientCart client)
        {
              _medContext.UpdateClient(client);
        }

        public string AddingClientCart(ClientCart client)
        {
         
            _medContext.AddClient(client);
            return null;
        }
    }
}
