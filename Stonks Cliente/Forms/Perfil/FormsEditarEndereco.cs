using Stonks_Adm.Communs;
using Stonks_Cliente.Entity;
using Stonks_Cliente.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Forms.Perfil
{
    public partial class FormsEditarEndereco : Form
    {
        string localEndereco = @"C:\temp\EnderecoJson.json";
        
        ListDelivery listaDelivery;

        public FormsEditarEndereco()
        {
            InitializeComponent();
            listaDelivery = new ListDelivery();
            listaDelivery.lista = Json.lerArquivoDeliveryJSON(localEndereco);
            ReceberValores();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            foreach (var enderecos in listaDelivery.lista)
            {
                if(cBoxNomes.SelectedItem == enderecos.Nome)
                {
                    tBoxComplemento.Text = enderecos.Complemento;
                    tBoxNome.Text = enderecos.Complemento;
                    maskedTBCep.Text = enderecos.Cep;
                    tBoxRua.Text = enderecos.Rua;
                    tBoxNumero.Text = enderecos.Numero;
                    tBoxBairro.Text = enderecos.Bairro;
                    tBoxCidade.Text = enderecos.Cidade;
                    tBoxEstado.Text = enderecos.Estado;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (maskedTBCep.Text == null || tBoxRua.Text == "" || tBoxNumero.Text == "" || tBoxBairro.Text == "" || tBoxCidade.Text == "" || tBoxEstado.Text == "" || tBoxNome.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios");
            }
            else
            {
                EditarEndereco(listaDelivery.lista);
                Json.salvaEnderecoJSON(localEndereco, listaDelivery.lista);
                listaDelivery.lista = Json.lerArquivoDeliveryJSON(localEndereco);
            }
            ReceberValores();
        }

        private void EditarEndereco(List<Delivery> lista)
        {
            foreach (var enderecos in listaDelivery.lista)
            {
                if (cBoxNomes.SelectedItem == enderecos.Nome)
                {
                    enderecos.Complemento = tBoxComplemento.Text;
                    enderecos.Nome = tBoxNome.Text;
                    enderecos.Cep = maskedTBCep.Text;
                    enderecos.Rua = tBoxRua.Text;
                    enderecos.Numero = tBoxNumero.Text;
                    enderecos.Bairro = tBoxBairro.Text;
                    enderecos.Cidade = tBoxCidade.Text;
                    enderecos.Estado = tBoxEstado.Text;

                    MessageBox.Show("Edição realizada!");
                }
            }
        }

        private void btnVerificarCep_Click(object sender, EventArgs e)
        {
            VerificarCep();
        }

        private void VerificarCep()
        {
            try
            {
                ServiceReferenceCep.AtendeClienteClient consulta = new ServiceReferenceCep.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(maskedTBCep.Text);

                if (resultado != null)
                {
                    tBoxRua.Text = resultado.end;
                    tBoxBairro.Text = resultado.bairro;
                    tBoxCidade.Text = resultado.cidade;
                    tBoxEstado.Text = resultado.uf;
                    MessageBox.Show("Cep Encontrado!");
                }
            }

            catch (FaultException)
            {
                MessageBox.Show("CEP NÃO ENCONTRADO OU INEXISTENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTBCep.Clear();
                maskedTBCep.Focus();
            }

            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possível completar a operação\nVerifique sua conexão com a internet.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTBCep.Clear();
            }

        }

        private void ReceberValores()
        {           
        cBoxNomes.Items.Clear();

            foreach (var enderecos in listaDelivery.FiltrarCpf(Login.CPF))
            {
                 cBoxNomes.Items.Add(enderecos.Nome);  
            }
        }

    }
}
