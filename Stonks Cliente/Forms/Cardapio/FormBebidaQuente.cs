using Stonks.Communs;
using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using Stonks_Cliente.Entity;
using Stonks_Cliente.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Forms.Cardapio
{
    public partial class FormBebidaQuente : Form
    {
        ListProdutos listaProdutos;
        ListCarrinho listaCarrinho;

        string localProduto = @"C:\temp\ProdutosJson.json";
        string localCarrinho = @"C:\temp\CarrinhoJson.json";

        public FormBebidaQuente()
        {
            InitializeComponent();
            listaCarrinho = new ListCarrinho();
            listaCarrinho.lista = Json.lerArquivoProdutosJSON(localCarrinho);
            listaProdutos = new ListProdutos();
            listaProdutos.lista = Json.lerArquivoProdutosJSON(localProduto);
            Listar(listaProdutos.GetListBebidaQuente());
        }

        private void btnAddCarrinho_Click_1(object sender, EventArgs e)
        {
            if (tBoxID.Text == "" || tBoxQuantidade.Text == "")
            {
                MessageBox.Show("Todos os Campos são Obrigatórios!");
            }
            else if (Login.CPF == null)
            {
                MessageBox.Show("Necessário estar logado para realizar um pedido");
            }
            else
            {
                foreach (var produto in listaProdutos.GetListBebidaQuente())
                {
                    if (produto.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        produto.Quantidade = Convercao.ConvertInt(tBoxQuantidade.Text);
                        produto.CPF = Login.CPF;
                        listaCarrinho.InserirProduto(produto);
                        Json.salvaProdutoJSON(localCarrinho, listaCarrinho.GetList());
                        MessageBox.Show("Produto Adicionado no Carrinho!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }
                }
            }
        }

        private void Listar(List<Produto> lista)
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = lista;
        }
    }
}
