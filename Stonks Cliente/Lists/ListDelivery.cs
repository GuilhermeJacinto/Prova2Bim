using Stonks_Cliente.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Cliente.Lists
{
    class ListDelivery
    {
        public List<Delivery> lista = new List<Delivery>();

        public void InserirDelivery(Delivery delivery)
        {
            this.lista.Add(delivery);
        }

        public List<Delivery> GetList()
        {
            return lista;
        }

        public List<Delivery> FiltrarCpf(string CPF)
        {
            List<Delivery> listaAux = new List<Delivery>();

            foreach(var local in lista)
            {
                if(CPF == local.ClienteCpf)
                {
                    listaAux.Add(local);
                }
            }
            return listaAux;
        }
    }
}
