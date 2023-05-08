using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ClientService
    {
        public static List<Cliente> ListAll()
        {
            return ClientRepository.ListAll();
        }
        public static Cliente Insert(Cliente cliente)
        {
            return ClientRepository.Insert(cliente);
        }

    }
}
