using Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions
{
    public interface IClientCartRepository
    {
        IEnumerable<ClientCart> GetAllClients();
        void AddClient(ClientCart client);

        Task<ClientCart> FindClient(Guid guid);

        void UpdateClient(ClientCart client);
        void RemoveClient(ClientCart client);
    }
}
