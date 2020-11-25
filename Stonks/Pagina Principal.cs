using Stonks.Communs;
using Stonks.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks
{
    public partial class Form1 : Form
    {
        List<Produto> listaProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
            AllInvisible();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            Cadastrar();
            btnCadastrar.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto cadProdutos = GetProduto();
                listaProdutos.Add(cadProdutos);
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
            dataGVListar.Visible = true;
        }

        private void editarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            MostrarId();
            dataGVListar.Visible = true;
            Listar(listaProdutos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto(listaProdutos);
            Listar(listaProdutos);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDados(listaProdutos);
                Cadastrar();
                btnEditar.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir um Valor Válido!");
            }
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
                        return true;
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private void removerProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            MostrarId();
            btnMostrar.Visible = false;
            btnRemover.Visible = true;
            Listar(listaProdutos);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover(listaProdutos);
            Listar(listaProdutos);
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

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            MostrarId();
            lblId.Text = "Nome a ser procurado:";
            btnMostrar.Visible = false;
            btnPesquisar.Visible = true;
            Listar(listaProdutos);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            if (MessageBox.Show("Deseja Realmente Sair?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListarPorNome(listaProdutos);
        }

        private void ListarPorNome(List<Produto> listaProdutos)
        {
            List<Produto> listaAuxProdutos = new List<Produto>();

            foreach (var produto in listaProdutos)
            {
                if (tBoxID.Text == produto.Nome)
                {
                    listaAuxProdutos.Add(produto);//<<<terminar
                    //listaAuxProdutos.AddRange(listaProdutos.Where(r => r.StartsWith(lblId.Text)); //>> Teste
                }
            }
            if (ContagemList(listaAuxProdutos) == 0)
            {
                MessageBox.Show("Produto não encontrado!");
            }
            else
            {
                Listar(listaAuxProdutos);
            }
            Listar(listaAuxProdutos);
        }

        private void MostrarId()
        {
            lblId.Visible = true;
            tBoxID.Visible = true;
            btnMostrar.Visible = true;
        }

        private void Cadastrar()
        {
            lblCategoria.Visible = true;
            cBoxMedida.Visible = true;
            lblNome.Visible = true;
            lblValor.Visible = true;
            lblMedida.Visible = true;
            tBoxNome.Visible = true;
            tBoxValor.Visible = true;
            cBoxMedida.Visible = true;
            cBoxCategoria.Visible = true;
            dataGVListar.Visible = true;
        }

        private void AllInvisible()
        {
            lblCategoria.Visible = false;
            lblMedida.Visible = false;
            lblNome.Visible = false;
            lblId.Visible = false;
            lblValor.Visible = false;
            tBoxNome.Visible = false;
            tBoxID.Visible = false;
            tBoxValor.Visible = false;
            cBoxMedida.Visible = false;
            cBoxCategoria.Visible = false;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            dataGVListar.Visible = false;
            btnMostrar.Visible = false;
            btnPesquisar.Visible = false;
        }

        private void LimpaCampo()
        {
            tBoxNome.Clear();
            cBoxCategoria.SelectedIndex = -1;
            cBoxMedida.SelectedIndex = -1;
            tBoxValor.Clear();
        }
    }
}
