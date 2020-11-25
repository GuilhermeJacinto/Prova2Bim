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
    public partial class FormEditarDadosPerfil : Form
    {
        string localCliente = @"C:\temp\ClienteJson.json";

        ListCliente listaCliente;

        public FormEditarDadosPerfil()
        {
            InitializeComponent();
            listaCliente = new ListCliente();
            listaCliente.lista = Json.lerArquivoPessoasJSON(localCliente);
            ReceberValores();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (tBoxNome.Text == "" || maskedTBCpf.Text == "" || tBoxEmail.Text == "" || tBoxSenha.Text == "" || tBoxRptSenha.Text == "" || maskedTBContato.Text == "" || maskedTBDataNasc.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else if (tBoxSenha.Text != tBoxRptSenha.Text)
            {
                MessageBox.Show("As senhas devem ser iguais!");
            }
            else
            {
                EditarValores();
                Json.salvaJSON(localCliente, listaCliente.lista);
            } 
        }

        private void EditarValores()
        {
            foreach (var cadastros in listaCliente.lista)
            {
                if (Login.CPF == cadastros.CPF)
                {
                    cadastros.Nome = tBoxNome.Text;
                    cadastros.CPF = maskedTBCpf.Text;
                    cadastros.Email = tBoxEmail.Text;
                    cadastros.Senha = tBoxSenha.Text;
                    cadastros.RepetirSenha = tBoxRptSenha.Text;
                    cadastros.Contato = maskedTBContato.Text;
                    cadastros.DataNasc = maskedTBDataNasc.Text;

                    MessageBox.Show("Edição realizada!");
                }
            }
        }

        private void ReceberValores()
        {
            foreach(var cadastros in listaCliente.lista)
            {
                if (Login.CPF == cadastros.CPF)
                {
                    tBoxNome.Text = cadastros.Nome;
                    maskedTBCpf.Text = cadastros.CPF;
                    maskedTBCpf.Enabled = false;
                    tBoxEmail.Text = cadastros.Email;
                    tBoxSenha.Text = cadastros.Senha;
                    tBoxRptSenha.Text = cadastros.RepetirSenha;
                    maskedTBContato.Text = cadastros.Contato;
                    maskedTBDataNasc.Text = cadastros.DataNasc;
                }
            }
        }
    }
}
