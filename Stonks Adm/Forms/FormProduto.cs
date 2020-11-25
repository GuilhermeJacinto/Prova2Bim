using Stonks.Communs;
using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Adm.Forms
{
    public partial class FormProduto : Form
    {
        List<Produto> listaProdutos;
        string local = @"C:\temp\ProdutosJson.json";

        public FormProduto(List<Produto> listaProduto)
        {
            InitializeComponent();
            this.listaProdutos = listaProduto;
            Allinvisable();
        }

        public FormProduto()
        {
        }

        private void btnPagCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro();
            LimpaCampo();
            Listar(listaProdutos);
        }

        private void btnPagEditar_Click(object sender, EventArgs e)
        {
            FormID();
            Listar(listaProdutos);
            btnVerificar.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDados(listaProdutos);
                FormVerificar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir um Valor Válido!");
            }
        }

        private void btnPagRemover_Click(object sender, EventArgs e)
        {
            FormID();
            Listar(listaProdutos);
            btnMostrarDelete.Visible = true;
        }

        private void btnMostrarDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDados(listaProdutos);
                FormRemover();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir um Valor Válido!");
            }
        }

        private void btnPagCategoria_Click(object sender, EventArgs e)
        {
            //Listar(listaProdutos);
        }

        private void picBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha a pagina aberta
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto cadProdutos = GetProduto();
                listaProdutos.Add(cadProdutos);
                Json.salvaPessoaJSON(local, listaProdutos);
                Listar(listaProdutos);
                LimpaCampo();
                MessageBox.Show("Produto Inserido com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir Valores Validos!");
            }
        }

        private Produto GetProduto()
        {
            Produto cadProdutos = new Produto();

            cadProdutos.Id = AutoId(listaProdutos); ;
            cadProdutos.Nome = tBoxNome.Text;
            cadProdutos.Tipo = Convert.ToString(cBoxCategoria.SelectedItem);
            cadProdutos.Valor = Convercao.ConvertFloat(tBoxValor.Text);
            cadProdutos.Medida = Convert.ToString(cBoxMedida.SelectedItem);
            cadProdutos.Faixa = Convert.ToString(cBoxFaixa.SelectedItem);
            cadProdutos.Lucro = Convercao.ConvertFloat(tBoxLucro.Text);

            return cadProdutos;
        }

        private int AutoId(List<Produto> listaProdutos)
        {
            int id;
            if (ContagemList(listaProdutos) == 0)
            {
                return id = 1;
            }
            else
            {
                Produto[] produtosArray = listaProdutos.ToArray();
                Produto produto = produtosArray[produtosArray.Length - 1];
                id = produto.Id;
                return id + 1;
            }
        }

        private int ContagemList(List<Produto> listaProdutos)
        {
            int contagem = listaProdutos.Count();
            return contagem;
        }

        private void Listar(List<Produto> lista)
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = lista;
        }

        private void LimpaCampo()
        {
            tBoxNome.Clear();
            cBoxCategoria.SelectedIndex = -1;
            cBoxMedida.SelectedIndex = -1;
            tBoxValor.Clear();
            cBoxFaixa.SelectedIndex = -1;
            tBoxLucro.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto(listaProdutos);
            Listar(listaProdutos);
            Json.salvaPessoaJSON(local, listaProdutos);
        }

        private bool EditarProduto(List<Produto> listaProdutos)
        {
            if (ContagemList(listaProdutos) == 0)
            {
                MessageBox.Show("Nenhuma Produto Cadastrado!");
            }
            else
            {
                foreach (var cadastros in listaProdutos)
                {
                    if (cadastros.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        cadastros.Nome = tBoxNome.Text;
                        cadastros.Tipo = cBoxCategoria.Text;
                        cadastros.Valor = Convercao.ConvertFloat(tBoxValor.Text);
                        cadastros.Medida = cBoxMedida.Text;
                        cadastros.Lucro = Convercao.ConvertFloat(tBoxLucro.Text);
                        cadastros.Faixa = cBoxFaixa.Text;

                        MessageBox.Show("Edição Realizada!");
                        return true;
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private bool MostrarDados(List<Produto> listaProdutos)
        {
            if (ContagemList(listaProdutos) == 0)
            {
                MessageBox.Show("Nenhum Dados para Mostrar!");
            }
            else
            {
                foreach (var cadastros in listaProdutos)
                {
                    if (cadastros.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        tBoxNome.Text = cadastros.Nome;
                        cBoxCategoria.SelectedItem = cadastros.Tipo;
                        tBoxValor.Text = Convercao.ConverFloatToString(cadastros.Valor);
                        cBoxMedida.Text = cadastros.Medida;
                        tBoxLucro.Text = Convercao.ConverFloatToString(cadastros.Lucro);
                        cBoxFaixa.SelectedItem = cadastros.Faixa;

                        return true;
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover(listaProdutos);
            Listar(listaProdutos);
            Json.salvaPessoaJSON(local, listaProdutos);
        }

        private bool Remover(List<Produto> listaProdutos)
        {
            if (ContagemList(listaProdutos) == 0)
            {
                MessageBox.Show("Nenhuma Produto Cadastrado!");
            }
            else
            {
                foreach (var cadastros in listaProdutos)
                {
                    if (cadastros.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        if (MessageBox.Show("Deseja Realmente Remover?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MessageBox.Show("Cadastro Removido com Sucesso!");
                            listaProdutos.Remove(cadastros);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cadastro Não Removido!");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private void Allinvisable()
        {
            lblId.Visible = false;
            tBoxID.Visible = false;
            btnVerificar.Visible = false;
            btnMostrarDelete.Visible = false;
            lblNome.Visible = false;
            tBoxNome.Visible = false;
            lblCategoria.Visible = false;
            cBoxCategoria.Visible = false;
            lblMedida.Visible = false;
            cBoxMedida.Visible = false;
            lblValor.Visible = false;
            tBoxValor.Visible = false;
            lblFaixa.Visible = false;
            tBoxLucro.Visible = false;
            lblTaxa.Visible = false;
            cBoxFaixa.Visible = false;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            dataGVListar.Visible = false;
        }

        private void FormCadastro()
        {
            lblId.Visible = false;
            tBoxID.Visible = false;
            btnVerificar.Visible = false;
            lblNome.Visible = true;
            tBoxNome.Visible = true;
            lblCategoria.Visible = true;
            cBoxCategoria.Visible = true;
            lblMedida.Visible = true;
            cBoxMedida.Visible = true;
            lblValor.Visible = true;
            tBoxValor.Visible = true;
            btnCadastrar.Visible = true;
            lblFaixa.Visible = true;
            tBoxLucro.Visible = true;
            lblTaxa.Visible = true;
            cBoxFaixa.Visible = true;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            dataGVListar.Visible = true;
            btnMostrarDelete.Visible = false;

            lblNome.Enabled = true;
            tBoxNome.Enabled = true;
            lblCategoria.Enabled = true;
            cBoxCategoria.Enabled = true;
            lblMedida.Enabled = true;
            cBoxMedida.Enabled = true;
            lblValor.Enabled = true;
            tBoxValor.Enabled = true;
        }

        private void FormID()
        {
            lblId.Visible = true;
            tBoxID.Visible = true;
            btnVerificar.Visible = false;
            btnMostrarDelete.Visible = false;
            lblNome.Visible = false;
            tBoxNome.Visible = false;
            lblCategoria.Visible = false;
            cBoxCategoria.Visible = false;
            lblMedida.Visible = false;
            cBoxMedida.Visible = false;
            lblValor.Visible = false;
            tBoxValor.Visible = false;
            lblFaixa.Visible = false;
            tBoxLucro.Visible = false;
            lblTaxa.Visible = false;
            cBoxFaixa.Visible = false;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            dataGVListar.Visible = true;
        }

        private void FormVerificar()
        {
            lblId.Visible = true;
            tBoxID.Visible = true;
            btnVerificar.Visible = true;
            lblNome.Visible = true;
            tBoxNome.Visible = true;
            lblCategoria.Visible = true;
            cBoxCategoria.Visible = true;
            lblMedida.Visible = true;
            cBoxMedida.Visible = true;
            lblValor.Visible = true;
            tBoxValor.Visible = true;
            lblFaixa.Visible = true;
            tBoxLucro.Visible = true;
            lblTaxa.Visible = true;
            cBoxFaixa.Visible = true;
            btnCadastrar.Visible = false;
            btnEditar.Visible = true;
            btnRemover.Visible = false;
            dataGVListar.Visible = true;

            lblNome.Enabled = true;
            tBoxNome.Enabled = true;
            lblCategoria.Enabled = true;
            cBoxCategoria.Enabled = true;
            lblMedida.Enabled = true;
            cBoxMedida.Enabled = true;
            lblValor.Enabled = true;
            tBoxValor.Enabled = true;
        }

        private void FormRemover()
        {
            lblId.Visible = true;
            tBoxID.Visible = true;
            btnVerificar.Visible = false;
            lblNome.Visible = true;
            tBoxNome.Visible = true;
            lblCategoria.Visible = true;
            cBoxCategoria.Visible = true;
            lblMedida.Visible = true;
            cBoxMedida.Visible = true;
            lblValor.Visible = true;
            tBoxValor.Visible = true;
            lblFaixa.Visible = true;
            tBoxLucro.Visible = true;
            lblTaxa.Visible = true;
            cBoxFaixa.Visible = true;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = true;
            dataGVListar.Visible = true;

            lblNome.Enabled = false;
            tBoxNome.Enabled = false;
            lblCategoria.Enabled = false;
            cBoxCategoria.Enabled = false;
            lblMedida.Enabled = false;
            cBoxMedida.Enabled = false;
            lblValor.Enabled = false;
            tBoxValor.Enabled = false;
            lblFaixa.Enabled = false;
            tBoxLucro.Enabled = false;
            lblTaxa.Enabled = false;
            cBoxFaixa.Enabled = false;
        }
    }
}
