using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Forms.Cardapio
{
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void btnCardPani_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormPanificacao panificacao = new Forms.Cardapio.FormPanificacao();
            panificacao.TopLevel = false;
            panificacao.Visible = true;
            panificacao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panificacao.MaximizeBox = true;
            panificacao.AutoSize = true;
            panificacao.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(panificacao);
        }

        private void btnCardConf_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormConfeitaria confeitaria = new Forms.Cardapio.FormConfeitaria();
            confeitaria.TopLevel = false;
            confeitaria.Visible = true;
            confeitaria.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            confeitaria.MaximizeBox = true;
            confeitaria.AutoSize = true;
            confeitaria.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(confeitaria);
        }

        private void btnCardLanche_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormLanches lanche = new Forms.Cardapio.FormLanches();
            lanche.TopLevel = false;
            lanche.Visible = true;
            lanche.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lanche.MaximizeBox = true;
            lanche.AutoSize = true;
            lanche.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(lanche);
        }

        private void btnCardBebidaGelada_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormBebidaGelada gelada = new Forms.Cardapio.FormBebidaGelada();
            gelada.TopLevel = false;
            gelada.Visible = true;
            gelada.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gelada.MaximizeBox = true;
            gelada.AutoSize = true;
            gelada.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(gelada);
        }

        private void btnCardBebidaQuente_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormBebidaQuente quente = new Forms.Cardapio.FormBebidaQuente();
            quente.TopLevel = false;
            quente.Visible = true;
            quente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quente.MaximizeBox = true;
            quente.AutoSize = true;
            quente.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(quente);
        }

        private void btnCardSalg_Click(object sender, EventArgs e)
        {
            Forms.Cardapio.FormSalgados salgados = new Forms.Cardapio.FormSalgados();
            salgados.TopLevel = false;
            salgados.Visible = true;
            salgados.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            salgados.MaximizeBox = true;
            salgados.AutoSize = true;
            salgados.Size = panelForms.Size;
            panelForms.BringToFront();
            panelForms.Controls.Add(salgados);
        }
    }
}
