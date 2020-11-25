using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Cliente.Lists
{
    class ListCarrinho
    {
        public List<Produto> lista = new List<Produto>();

        public void InserirProduto(Produto produto)
        {
            lista.Add(produto);
        }

        public List<Produto> GetList()
        {
            return lista;
        }

        public List<Produto> FiltrarCpf(string CPF)
        {
            List<Produto> listaAux = new List<Produto>();

            foreach (var local in lista)
            {
                if (CPF == local.CPF)
                {
                    listaAux.Add(local);
                }
            }
            return listaAux;
        }

        public void RemoverLista(int id, string local)
        {
            foreach (var produto in lista)
            {
                if (id == produto.Id)
                {
                    lista.Remove(produto);
                    Json.salvaProdutoJSON(local, this.lista);
                    return;
                }
            }
        }

        public void ArrumarLista(int id, double quantidade, string local)
        {
            foreach (var produto in lista)
            {
                if (id == produto.Id)
                {
                    produto.Quantidade = produto.Quantidade - quantidade;
                    Json.salvaProdutoJSON(local, this.lista);
                }
            }
        }
    }
}
