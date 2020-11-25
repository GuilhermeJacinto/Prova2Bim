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
    public partial class FormCadEndereco : Form
    {
        string localEndereco = @"C:\temp\EnderecoJson.json";

        ListDelivery listaDelivery;

        Delivery delivery;

        public FormCadEndereco()
        {
            InitializeComponent();
            listaDelivery = new ListDelivery();
            listaDelivery.lista = Json.lerArquivoDeliveryJSON(localEndereco);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (maskedTBCep.Text == null || tBoxRua.Text == "" || tBoxNumero.Text == "" || tBoxBairro.Text == "" || tBoxCidade.Text == "" || tBoxEstado.Text == "" || tBoxNome.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios");
            }
            else
            {
                delivery = new Delivery(maskedTBCep.Text, tBoxRua.Text, tBoxNumero.Text, tBoxBairro.Text, tBoxCidade.Text, tBoxEstado.Text, tBoxComplemento.Text, tBoxNome.Text);
                listaDelivery.InserirDelivery(delivery);
                Json.salvaEnderecoJSON(localEndereco, listaDelivery.GetList());

                MessageBox.Show("Endereço Cadastrado");
            }         
        }

    }
}
