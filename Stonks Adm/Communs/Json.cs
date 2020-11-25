using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Stonks_Adm.Communs
{
    public class Json
    {

        static public void salvaPessoaJSON(String local, List<Produto> lista)
        {
            StreamWriter file = new StreamWriter(local); //verificar com professor
            lista.ForEach(produto =>
            {
                string output = JsonConvert.SerializeObject(produto);
                file.WriteLine(output);
            });
            file.Close();
        }

        static public List<Produto> lerArquivoPessoasJSON(String local)
        {
            List<Produto> listaAuxProduto = new List<Produto>();

            if (File.Exists(local))
            {
                string linha;

                StreamReader file = new StreamReader(local);
                while ((linha = file.ReadLine()) != null)
                {
                    Produto produto = JsonConvert.DeserializeObject<Produto>(linha);
                    listaAuxProduto.Add(produto);
                }

                file.Close();
                return listaAuxProduto;
            }
            else
            {
                return listaAuxProduto;
            }
        }

    }
}
