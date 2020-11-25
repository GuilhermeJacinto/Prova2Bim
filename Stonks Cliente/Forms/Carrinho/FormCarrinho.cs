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

namespace Stonks_Cliente.Forms.Carrinho
{
    public partial class FormCarrinho : Form
    {
        ListCliente listaCliente;
        ListCarrinho listaCarrinho;
        Caixa valores;

        string localCarrinho = @"C:\temp\CarrinhoJson.json";
        string localCliente = @"C:\temp\ClienteJson.json";

        public FormCarrinho()
        {
            InitializeComponent();
            listaCliente = new ListCliente();
            listaCliente.lista = Json.lerArquivoPessoasJSON(localCliente);
            listaCarrinho = new ListCarrinho();
            listaCarrinho.lista = Json.lerArquivoProdutosJSON(localCarrinho);
            Listar(listaCarrinho.FiltrarCpf(Login.CPF));
            lblValor.Text = Caixa.ReturnValor(listaCarrinho.lista).ToString("c2");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!Login.login || listaCarrinho.FiltrarCpf(Login.CPF).Count() == 0)
            {
                MessageBox.Show("Não possivel prosseguir!");                
            }
            else
            {
                foreach(var clientes in listaCliente.lista)
                {
                    if (clientes.CPF == Login.CPF)
                    {
                        foreach(var produtos in listaCarrinho.lista)
                        {
                            if (produtos.Faixa == "Maior de 18" && clientes.Idade < 18)
                            {
                                MessageBox.Show("Cliente não pode comprar o item " + produtos.Nome + " devido sua idade");
                                return;
                            }
                        }
                    }
                }

                Forms.Carrinho.FormCaixa caixa = new Forms.Carrinho.FormCaixa();
                caixa.TopLevel = false;
                caixa.Visible = true;
                caixa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                caixa.MaximizeBox = true;
                caixa.AutoSize = true;
                caixa.Size = panelForms.Size;
                panelForms.BringToFront();
                panelForms.Controls.Add(caixa);
            }          
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (tBoxQuantidade.Text == "" || tBoxID.Text == "")
            {
                MessageBox.Show("Ambos os Campos são Obrigatórios!");

            }
            else if (listaCarrinho.FiltrarCpf(Login.CPF).Count() == 0)
            {
                MessageBox.Show("Não há nada para remover");
            }
            else
            {
                foreach (var produtos in listaCarrinho.lista)
                {
                    if (tBoxID.Text == produtos.Id.ToString())
                    {
                        if (Convercao.ConvertDouble(tBoxQuantidade.Text) > produtos.Quantidade)
                        {
                            MessageBox.Show("Valor Inválido!");
                        }
                        else if (Convercao.ConvertDouble(tBoxQuantidade.Text) == produtos.Quantidade)
                        {
                            MessageBox.Show("Produto Removido");
                            listaCarrinho.RemoverLista(Convercao.ConvertInt(tBoxID.Text), localCarrinho);
                            Listar(listaCarrinho.FiltrarCpf(Login.CPF));
                            lblValor.Text = Caixa.ReturnValor(listaCarrinho.lista).ToString("c2");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Quantidade Diminuida");
                            listaCarrinho.ArrumarLista(Convercao.ConvertInt(tBoxID.Text), Convercao.ConvertDouble(tBoxQuantidade.Text), localCarrinho);
                            Listar(listaCarrinho.FiltrarCpf(Login.CPF));
                            lblValor.Text = Caixa.ReturnValor(listaCarrinho.lista).ToString("c2");
                        }
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