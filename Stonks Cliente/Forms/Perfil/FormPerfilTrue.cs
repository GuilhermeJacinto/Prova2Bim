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
    public partial class FormPerfilTrue : System.Windows.Forms.Form
    {
        ListCliente lista;

        string localCliente = @"C:\temp\ClienteJson.json";

        public FormPerfilTrue()
        {
            InitializeComponent();
            lista = new ListCliente();
            lista.lista = Json.lerArquivoPessoasJSON(localCliente);
            lblPerfil.Text = lista.GetNameList(Login.CPF) + ".";
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Login.login = false;
            this.Close();
        }

        private void btnCadEndereco_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormCadEndereco cadEndereco = new Forms.Perfil.FormCadEndereco();
            cadEndereco.TopLevel = false;
            cadEndereco.Visible = true;
            cadEndereco.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cadEndereco.MaximizeBox = true;
            cadEndereco.AutoSize = true;
            cadEndereco.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(cadEndereco);
        }

        private void btnEnderecos_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormsMeusEnderecos Enderecos = new Forms.Perfil.FormsMeusEnderecos();
            Enderecos.TopLevel = false;
            Enderecos.Visible = true;
            Enderecos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Enderecos.MaximizeBox = true;
            Enderecos.AutoSize = true;
            Enderecos.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(Enderecos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormsEditarEndereco Enderecos = new Forms.Perfil.FormsEditarEndereco();
            Enderecos.TopLevel = false;
            Enderecos.Visible = true;
            Enderecos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Enderecos.MaximizeBox = true;
            Enderecos.AutoSize = true;
            Enderecos.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(Enderecos);
        }

        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormEditarDadosPerfil Enderecos = new Forms.Perfil.FormEditarDadosPerfil();
            Enderecos.TopLevel = false;
            Enderecos.Visible = true;
            Enderecos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Enderecos.MaximizeBox = true;
            Enderecos.AutoSize = true;
            Enderecos.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(Enderecos);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
