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
    public partial class FormCadastroCliente : System.Windows.Forms.Form
    {

        string localCliente = @"C:\temp\ClienteJson.json";

        private ListCliente listaCadastros;

        public FormCadastroCliente()
        {
            InitializeComponent();
            listaCadastros = new ListCliente();
            listaCadastros.lista = Json.lerArquivoPessoasJSON(localCliente);
            Listar(listaCadastros.lista);
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
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
                foreach (var clientes in listaCadastros.lista)
                {
                    if (listaCadastros.lista.Count() == 0)
                    {
                        if (clientes.CPF == maskedTBCpf.Text)
                        {
                            MessageBox.Show("Cpf já utilizado favor insirir outro");
                            return;
                        }
                        else if (clientes.Email == tBoxEmail.Text)
                        {
                            MessageBox.Show("Email já utilizado favor insirir outro");
                            return;
                        }
                    }
                }
                try
                {
                    Cliente cliente = new Cliente(tBoxNome.Text, maskedTBCpf.Text, tBoxSenha.Text, tBoxRptSenha.Text, maskedTBContato.Text, tBoxEmail.Text, maskedTBDataNasc.Text);
                    listaCadastros.InserirCliente(cliente);
                    Json.salvaJSON(localCliente, listaCadastros.GetList());
                    Listar(listaCadastros.GetList());
                    MessageBox.Show("Cadastro Realizado!");
                }
                catch
                {
                    MessageBox.Show("Favor Inserir Valores Válidos!");
                }                      
            }
        }

        private void Listar(List<Cliente> lista)
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = lista;
        }

        private void LimparDados()
        {
            tBoxNome.Clear();
            maskedTBCpf.Clear();
            tBoxSenha.Clear();
            tBoxRptSenha.Clear();
            maskedTBContato.Clear();
            tBoxEmail.Clear();
        }

        private void btnLogCliente_Click(object sender, EventArgs e)
        {
            //foreach (var cadastros in listaCliente)
            //{
            //    if (cadastros.Nome == tBoxLogin.Text & cadastros.Senha == tBoxSenhaLog.Text)
            //    {
            //        MessageBox.Show("Logado com sucesso!");
            //    }
            //}
        }
    }
}
