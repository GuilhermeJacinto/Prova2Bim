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
    public partial class FormsPerfilFalse : System.Windows.Forms.Form
    {
        public FormsPerfilFalse()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormLoginCliente cliente = new Forms.Perfil.FormLoginCliente();
            cliente.TopLevel = false;
            cliente.Visible = true;
            cliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cliente.MaximizeBox = true;
            cliente.AutoSize = true;
            cliente.Size = panelForms.Size;
            panelForms.BringToFront();//pode ser
            panelForms.Controls.Add(cliente);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Forms.Perfil.FormCadastroCliente cliente = new Forms.Perfil.FormCadastroCliente();
            cliente.TopLevel = false;
            cliente.Visible = true;
            cliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cliente.MaximizeBox = true;
            cliente.AutoSize = true;
            cliente.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(cliente);
        }
    }
}
