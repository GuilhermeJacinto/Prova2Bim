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

namespace Stonks_Cliente.Forms.Perfil
{
    public partial class FormLoginCliente : System.Windows.Forms.Form
    {

        string localCliente = @"C:\temp\ClienteJson.json";

        private ListCliente listaCadastros;

        public FormLoginCliente()
        {
            InitializeComponent();
            listaCadastros = new ListCliente();
            listaCadastros.lista = Json.lerArquivoPessoasJSON(localCliente);
        }

        private void btnLogCliente_Click(object sender, EventArgs e)//virar metodo com return
        {
            foreach (var cadastros in listaCadastros.lista)
            {
                if (cadastros.Email == tBoxLogin.Text & cadastros.Senha == tBoxSenhaLog.Text)
                {
                    Login.login = true;
                    Login.CPF = cadastros.CPF;
                }
            }

            if (Login.login)
            {
                MessageBox.Show("Logado com sucesso!");

                Forms.Perfil.FormPerfilTrue perfil = new Forms.Perfil.FormPerfilTrue();
                perfil.TopLevel = false;
                perfil.Visible = true;
                perfil.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                perfil.MaximizeBox = true;
                perfil.AutoSize = true;
                perfil.Size = panelForms.Size;
                panelForms.BringToFront();
                panelForms.Controls.Add(perfil);
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tBoxSenhaLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
