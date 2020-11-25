using Stonks_Adm.Communs;
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

namespace Stonks_Cliente
{
    public partial class Index : Form
    {
        Login login;

        public Index()
        {
            InitializeComponent();
            login = new Login();

            Forms.FormHome home = new Forms.FormHome();
            home.TopLevel = false;
            home.Visible = true;
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.MaximizeBox = true;
            home.AutoSize = true;
            home.Size = panelForms.Size;
            panelForms.Controls.Add(home);
        }

        private void btnCadCliente_Click_1(object sender, EventArgs e)//<<<PERFIL>>>
        {
            panelForms.Controls.Clear();

            bool LoginUser = login.ReturnLogin();

            if (LoginUser)
            {
                Forms.Perfil.FormPerfilTrue cliente = new Forms.Perfil.FormPerfilTrue();
                cliente.TopLevel = false;
                cliente.Visible = true;
                cliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                cliente.MaximizeBox = true;
                cliente.AutoSize = true;
                cliente.Size = panelForms.Size;
                panelForms.Controls.Add(cliente);
            }
            else
            {
                Forms.Perfil.FormsPerfilFalse cliente = new Forms.Perfil.FormsPerfilFalse();
                cliente.TopLevel = false;
                cliente.Visible = true;
                cliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                cliente.MaximizeBox = true;
                cliente.AutoSize = true;
                cliente.Size = panelForms.Size;
                panelForms.Controls.Add(cliente);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            Forms.FormHome home = new Forms.FormHome();
            home.TopLevel = false;
            home.Visible = true;
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.MaximizeBox = true;
            home.AutoSize = true;
            home.Size = panelForms.Size;
            panelForms.Controls.Add(home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            Forms.Cardapio.FormCardapio cardapio = new Forms.Cardapio.FormCardapio();
            cardapio.TopLevel = false;
            cardapio.Visible = true;
            cardapio.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cardapio.MaximizeBox = true;
            cardapio.AutoSize = true;
            cardapio.Size = panelForms.Size;
            panelForms.Controls.Add(cardapio);
        }

        private void picBoxCarrinho_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            Forms.Carrinho.FormCarrinho carrinho = new Forms.Carrinho.FormCarrinho();
            carrinho.TopLevel = false;
            carrinho.Visible = true;
            carrinho.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            carrinho.MaximizeBox = true;
            carrinho.AutoSize = true;
            carrinho.Size = panelForms.Size;
            panelForms.Controls.Add(carrinho);

        }
    }
}
