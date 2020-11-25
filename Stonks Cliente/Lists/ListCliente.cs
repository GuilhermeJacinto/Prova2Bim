using Stonks_Adm.Communs;
using Stonks_Cliente.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Lists
{
    class ListCliente
    {

        public List<Cliente> lista = new List<Cliente>();

        public void InserirCliente(Cliente cliente)
        {
            lista.Add(cliente);
        }

        public List<Cliente> GetList()
        {
            return lista;
        }

        public String GetNameList(string CPF)
        {
            foreach(var login in lista)
            {
                if (CPF == login.CPF)
                {
                    return login.Nome;
                }
            }
            return "erro";
        }

    }
}
