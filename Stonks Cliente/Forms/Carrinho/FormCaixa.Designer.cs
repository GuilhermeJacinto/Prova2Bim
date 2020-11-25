namespace Stonks_Cliente.Forms.Carrinho
{
    partial class FormCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxPagamento = new System.Windows.Forms.ComboBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblDefinir = new System.Windows.Forms.Label();
            this.cBoxValor = new System.Windows.Forms.ComboBox();
            this.tBoxValor = new System.Windows.Forms.TextBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor a Pagar:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Red;
            this.lblValor.Location = new System.Drawing.Point(196, 55);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 25);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Opção de Pagamento:";
            // 
            // cBoxPagamento
            // 
            this.cBoxPagamento.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPagamento.FormattingEnabled = true;
            this.cBoxPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Debito"});
            this.cBoxPagamento.Location = new System.Drawing.Point(377, 115);
            this.cBoxPagamento.Name = "cBoxPagamento";
            this.cBoxPagamento.Size = new System.Drawing.Size(183, 27);
            this.cBoxPagamento.TabIndex = 13;
            this.cBoxPagamento.SelectedIndexChanged += new System.EventHandler(this.cBoxPagamento_SelectedIndexChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.Black;
            this.lblObs.Location = new System.Drawing.Point(56, 219);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(75, 30);
            this.lblObs.TabIndex = 14;
            this.lblObs.Text = "OBS:";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(239, 274);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(198, 39);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Realizar Pagamento";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblDefinir
            // 
            this.lblDefinir.AutoSize = true;
            this.lblDefinir.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinir.ForeColor = System.Drawing.Color.Black;
            this.lblDefinir.Location = new System.Drawing.Point(56, 163);
            this.lblDefinir.Name = "lblDefinir";
            this.lblDefinir.Size = new System.Drawing.Size(98, 30);
            this.lblDefinir.TabIndex = 16;
            this.lblDefinir.Text = "definir";
            // 
            // cBoxValor
            // 
            this.cBoxValor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxValor.FormattingEnabled = true;
            this.cBoxValor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9 (2% de juros)",
            "10 (3,25% de juros)",
            "11 (4,50% de juros)",
            "12 (5,75% de juros)"});
            this.cBoxValor.Location = new System.Drawing.Point(377, 163);
            this.cBoxValor.Name = "cBoxValor";
            this.cBoxValor.Size = new System.Drawing.Size(183, 27);
            this.cBoxValor.TabIndex = 17;
            this.cBoxValor.SelectedIndexChanged += new System.EventHandler(this.cBoxValor_SelectedIndexChanged);
            // 
            // tBoxValor
            // 
            this.tBoxValor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxValor.Location = new System.Drawing.Point(377, 163);
            this.tBoxValor.Name = "tBoxValor";
            this.tBoxValor.Size = new System.Drawing.Size(183, 27);
            this.tBoxValor.TabIndex = 18;
            this.tBoxValor.TextChanged += new System.EventHandler(this.tBoxValor_TextChanged);
            // 
            // panelForms
            // 
            this.panelForms.Controls.Add(this.label3);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(671, 316);
            this.panelForms.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, -53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meu Carrinho:";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 316);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.tBoxValor);
            this.Controls.Add(this.cBoxValor);
            this.Controls.Add(this.lblDefinir);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cBoxPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelForms);
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPagamento;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblDefinir;
        private System.Windows.Forms.ComboBox cBoxValor;
        private System.Windows.Forms.TextBox tBoxValor;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Label label3;
    }
}