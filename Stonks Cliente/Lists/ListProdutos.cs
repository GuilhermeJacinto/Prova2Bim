using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using Stonks_Cliente.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Lists
{
    class ListProdutos
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

        public List<Produto> GetListPanificacao()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach(var produtos in lista)
            {
                if(produtos.Tipo == "Panificação")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }

        public List<Produto> GetListConfeitaria()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach (var produtos in lista)
            {
                if (produtos.Tipo == "Confeitaria")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }

        public List<Produto> GetListLanche()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach (var produtos in lista)
            {
                if (produtos.Tipo == "Lanches")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }

        public List<Produto> GetListSalgados()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach (var produtos in lista)
            {
                if (produtos.Tipo == "Salgados")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }

        public List<Produto> GetListBebidaQuente()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach (var produtos in lista)
            {
                if (produtos.Tipo == "Bebidas Quentes")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }

        public List<Produto> GetListBebidaGeladas()
        {
            List<Produto> listaProdutoAux = new List<Produto>();

            foreach (var produtos in lista)
            {
                if (produtos.Tipo == "Bebidas Geladas")
                {
                    listaProdutoAux.Add(produtos);
                }
            }

            return listaProdutoAux;
        }
    }
}
