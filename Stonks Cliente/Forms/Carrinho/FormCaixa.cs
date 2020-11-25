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
    public partial class FormCaixa : Form
    {
        ListCarrinho listaCarrinho;

        string localCarrinho = @"C:\temp\CarrinhoJson.json";

        public FormCaixa()
        {
            InitializeComponent();
            listaCarrinho = new ListCarrinho();
            listaCarrinho.lista = Json.lerArquivoProdutosJSON(localCarrinho);
            listaCarrinho.lista = listaCarrinho.FiltrarCpf(Login.CPF);

            Caixa.Valor = Caixa.ReturnValor(listaCarrinho.lista);
            lblValor.Text = Caixa.Valor.ToString();

            lblObs.Visible = false;
            lblDefinir.Visible = false;
            cBoxValor.Visible = false;
            tBoxValor.Visible = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido realizado com sucesso!","Obrigado pela preferência!");
            //listaCarrinho.lista = listaCarrinho.LimpaCarrinho(Login.CPF);

            panelForms.Controls.Clear();

            Forms.FormHome home = new Forms.FormHome();
            home.TopLevel = false;
            home.Visible = true;
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.MaximizeBox = true;
            home.AutoSize = true;
            home.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(home);
        }

        private void cBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxPagamento.SelectedItem == "Dinheiro")
            {
                lblObs.Text = "Pagamentos a vista recebem 10% de desconto!";
                lblObs.Visible = true;
                lblValor.Text = Caixa.Desconto10().ToString("c2");
                lblDefinir.Visible = true;
                lblDefinir.Text = "Definir valor a ser pago:";
                cBoxValor.Visible = false;
                tBoxValor.Visible = true;
            }
            else if (cBoxPagamento.SelectedItem == "Cartão de Crédito")
            {
                lblObs.Text = "Parcelamentos em até 8 vezes sem juros!";
                lblObs.Visible = true;
                lblValor.Text = Caixa.Valor.ToString("c2");
                lblDefinir.Visible = true;
                lblDefinir.Text = "Defina Parcelas a pagar:";
                cBoxValor.Visible = true;
                tBoxValor.Visible = false;
            }
            else if (cBoxPagamento.SelectedItem == "Cartão de Debito")
            {
                lblObs.Text = "Pagamentos a vista recebem 10% de desconto!";
                lblObs.Visible = true;
                lblValor.Text = Caixa.Desconto10().ToString("c2");
                lblDefinir.Visible = false;
                cBoxValor.Visible = false;

            }
        }

        private void cBoxValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = Caixa.CartaoCredito((cBoxValor.SelectedIndex + 1)).ToString("c2") + " em " + (cBoxValor.SelectedIndex + 1) + " X.";
        }

        private void tBoxValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valor = Convercao.ConvertDouble(tBoxValor.Text);
                lblValor.Text = (Caixa.Valor.ToString("c2") + " com troco de: " + Caixa.Dinheiro(Convercao.ConvertDouble(tBoxValor.Text)).ToString("c2"));
            }
            catch
            {
                MessageBox.Show("Valor Inválido!");
                return;
            } 
        }

    }
}
