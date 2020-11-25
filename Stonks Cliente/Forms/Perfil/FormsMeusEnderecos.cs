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
    public partial class FormsMeusEnderecos : Form
    {
        ListDelivery lista;

        string localEndereco = @"C:\temp\EnderecoJson.json";

        public FormsMeusEnderecos()
        {
            InitializeComponent();
            lista = new ListDelivery();
            lista.lista = Json.lerArquivoDeliveryJSON(localEndereco);           
            Listar(lista.FiltrarCpf(Login.CPF));
        }

        private void Listar(List<Delivery> lista)
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = lista;
        }
    }
}
