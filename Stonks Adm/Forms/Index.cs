using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Adm.Forms
{
    public partial class Index : Form
    {
        List<Produto> listaProdutos;
        List<Fornecedor> listaFornecedor;
        string local = @"C:\temp\ProdutosJson.json";

        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaProdutos = new List<Produto>();
            listaProdutos = Json.lerArquivoPessoasJSON(local);
            Forms.FormProduto formularioProdutos = new Forms.FormProduto(listaProdutos);
            formularioProdutos.Show();
        }
    }
}
