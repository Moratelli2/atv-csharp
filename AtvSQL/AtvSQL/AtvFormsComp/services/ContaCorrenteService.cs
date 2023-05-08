using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ContaCorrenteService
    {
        public static model.ContaCorrente Insert(model.ContaCorrente contaCorrente)
        {
            return ContaCorrenteRepository.Insert(contaCorrente);
        }

        public static List<model.ContaCorrente> ListAll()
        {
            return ContaCorrenteRepository.ListAll();
        }

    }
}
