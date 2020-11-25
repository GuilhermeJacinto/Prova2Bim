namespace Stonks_Cliente.Forms.Cardapio
{
    partial class FormLanches
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
            this.dataGVListar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o Seu Produto!";
            // 
            // dataGVListar
            // 
            this.dataGVListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListar.Location = new System.Drawing.Point(29, 105);
            this.dataGVListar.Name = "dataGVListar";
            this.dataGVListar.Size = new System.Drawing.Size(613, 203);
            this.dataGVListar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade:";
            // 
            // tBoxQuantidade
            // 
            this.tBoxQuantidade.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxQuantidade.Location = new System.Drawing.Point(342, 60);
            this.tBoxQuantidade.Name = "tBoxQuantidade";
            this.tBoxQuantidade.Size = new System.Drawing.Size(100, 27);
            this.tBoxQuantidade.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID:";
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddCarrinho.FlatAppearance.BorderSize = 0;
            this.btnAddCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarrinho.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnAddCarrinho.Location = new System.Drawing.Point(465, 55);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(113, 36);
            this.btnAddCarrinho.TabIndex = 13;
            this.btnAddCarrinho.Text = "Comprar";
            this.btnAddCarrinho.UseVisualStyleBackColor = false;
            this.btnAddCarrinho.Click += new System.EventHandler(this.btnAddCarrinho_Click_1);
            // 
            // tBoxID
            // 
            this.tBoxID.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxID.Location = new System.Drawing.Point(103, 60);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(100, 27);
            this.tBoxID.TabIndex = 12;
            // 
            // FormLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCarrinho);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVListar);
            this.Name = "FormLanches";
            this.Text = "FormLanches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCarrinho;
        private System.Windows.Forms.TextBox tBoxID;
    }
}