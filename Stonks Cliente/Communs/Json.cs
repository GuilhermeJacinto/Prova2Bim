using Stonks_Cliente.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Stonks_Cliente.Lists;
using Stonks_Adm.Entity;

namespace Stonks_Adm.Communs
{
    public class Json
    {

        static public void salvaJSON(String local, List<Cliente> lista)
        {
            StreamWriter file = new StreamWriter(local); //verificar com professor
            lista.ForEach(produto =>
            {
                string output = JsonConvert.SerializeObject(produto);
                file.WriteLine(output);
            });
            file.Close();
        }

        static public List<Cliente> lerArquivoPessoasJSON(String local)//tentativa
        {
            ListCliente listaCadastros = new ListCliente();

            if (File.Exists(local))
            {
                string linha;

                StreamReader file = new StreamReader(local);
                while ((linha = file.ReadLine()) != null)
                {
                    Cliente cliente = JsonConvert.DeserializeObject<Cliente>(linha);
                    listaCadastros.InserirCliente(cliente);
                }

                file.Close();

                return listaCadastros.GetList();
            }
            else
            {
                return listaCadastros.GetList();
            }
        }

        ////Endereço////

        static public void salvaEnderecoJSON(String local, List<Delivery> lista)
        {
            StreamWriter file = new StreamWriter(local); //verificar com professor
            lista.ForEach(produto =>
            {
                string output = JsonConvert.SerializeObject(produto);
                file.WriteLine(output);
            });
            file.Close();
        }

        static public List<Delivery> lerArquivoDeliveryJSON(String local)
        {
            ListDelivery listaCadastros = new ListDelivery();

            if (File.Exists(local))
            {
                string linha;

                StreamReader file = new StreamReader(local);
                while ((linha = file.ReadLine()) != null)
                {
                    Delivery delivery = JsonConvert.DeserializeObject<Delivery>(linha);
                    listaCadastros.InserirDelivery(delivery);
                }

                file.Close();

                return listaCadastros.GetList();
            }
            else
            {
                return listaCadastros.GetList();
            }
        }

        ////Produto////

        static public void salvaProdutoJSON(String local, List<Produto> lista)
        {
            StreamWriter file = new StreamWriter(local); //verificar com professor
            lista.ForEach(produto =>
            {
                string output = JsonConvert.SerializeObject(produto);
                file.WriteLine(output);
            });
            file.Close();
        }

        static public List<Produto> lerArquivoProdutosJSON(String local)
        {
            ListProdutos listaProdutos = new ListProdutos();

            if (File.Exists(local))
            {
                string linha;

                StreamReader file = new StreamReader(local);
                while ((linha = file.ReadLine()) != null)
                {
                    Produto produtos = JsonConvert.DeserializeObject<Produto>(linha);
                    listaProdutos.InserirProduto(produtos);
                }

                file.Close();

                return listaProdutos.GetList();
            }
            else
            {
                return listaProdutos.GetList();
            }
        }
    }
}
