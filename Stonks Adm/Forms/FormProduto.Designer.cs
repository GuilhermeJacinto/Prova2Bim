namespace Stonks_Adm.Forms
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.cBoxMedida = new System.Windows.Forms.ComboBox();
            this.tBoxValor = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGVListar = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picBoxFechar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnPagCategoria = new System.Windows.Forms.Button();
            this.btnPagEditar = new System.Windows.Forms.Button();
            this.btnPagRemover = new System.Windows.Forms.Button();
            this.btnPagCadastro = new System.Windows.Forms.Button();
            this.btnMostrarDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBoxLucro = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.cBoxFaixa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxMedida
            // 
            this.cBoxMedida.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMedida.FormattingEnabled = true;
            this.cBoxMedida.Items.AddRange(new object[] {
            "Quilo",
            "Unidade",
            "Cento"});
            this.cBoxMedida.Location = new System.Drawing.Point(711, 137);
            this.cBoxMedida.Name = "cBoxMedida";
            this.cBoxMedida.Size = new System.Drawing.Size(124, 24);
            this.cBoxMedida.TabIndex = 59;
            // 
            // tBoxValor
            // 
            this.tBoxValor.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxValor.Location = new System.Drawing.Point(365, 137);
            this.tBoxValor.Name = "tBoxValor";
            this.tBoxValor.Size = new System.Drawing.Size(124, 23);
            this.tBoxValor.TabIndex = 58;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Items.AddRange(new object[] {
            "Panificação",
            "Confeitaria",
            "Lanches",
            "Salgados",
            "Bebidas Geladas",
            "Bebidas Quentes"});
            this.cBoxCategoria.Location = new System.Drawing.Point(710, 103);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(124, 24);
            this.cBoxCategoria.TabIndex = 57;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(365, 103);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(124, 23);
            this.tBoxNome.TabIndex = 56;
            // 
            // tBoxID
            // 
            this.tBoxID.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxID.Location = new System.Drawing.Point(231, 56);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(124, 23);
            this.tBoxID.TabIndex = 55;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(496, 140);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(206, 16);
            this.lblMedida.TabIndex = 54;
            this.lblMedida.Text = "Informar Unidade de Medida:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(223, 140);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(132, 16);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = " Valor de Compra:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(557, 106);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(144, 16);
            this.lblCategoria.TabIndex = 52;
            this.lblCategoria.Text = "Informar Categoria:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(242, 106);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 16);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Informar Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(198, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 16);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "ID:";
            // 
            // dataGVListar
            // 
            this.dataGVListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListar.GridColor = System.Drawing.Color.White;
            this.dataGVListar.Location = new System.Drawing.Point(182, 268);
            this.dataGVListar.Name = "dataGVListar";
            this.dataGVListar.Size = new System.Drawing.Size(682, 216);
            this.dataGVListar.TabIndex = 60;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(350, 219);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 28);
            this.btnCadastrar.TabIndex = 61;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(480, 219);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 28);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(610, 219);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(124, 28);
            this.btnRemover.TabIndex = 63;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(369, 53);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(124, 28);
            this.btnVerificar.TabIndex = 64;
            this.btnVerificar.Text = "Mostrar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.picBoxFechar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(876, 41);
            this.panelTitulo.TabIndex = 65;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(165, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(603, 32);
            this.lblTitulo.TabIndex = 68;
            this.lblTitulo.Text = "Stonks Administrativo Setor de Produtos";
            // 
            // picBoxFechar
            // 
            this.picBoxFechar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFechar.ErrorImage = null;
            this.picBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFechar.Image")));
            this.picBoxFechar.InitialImage = null;
            this.picBoxFechar.Location = new System.Drawing.Point(828, 0);
            this.picBoxFechar.Name = "picBoxFechar";
            this.picBoxFechar.Size = new System.Drawing.Size(45, 38);
            this.picBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFechar.TabIndex = 0;
            this.picBoxFechar.TabStop = false;
            this.picBoxFechar.Click += new System.EventHandler(this.picBoxFechar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.btnPagCategoria);
            this.panelMenuVertical.Controls.Add(this.btnPagEditar);
            this.panelMenuVertical.Controls.Add(this.btnPagRemover);
            this.panelMenuVertical.Controls.Add(this.btnPagCadastro);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 41);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(165, 455);
            this.panelMenuVertical.TabIndex = 66;
            // 
            // btnPagCategoria
            // 
            this.btnPagCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagCategoria.FlatAppearance.BorderSize = 0;
            this.btnPagCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagCategoria.ForeColor = System.Drawing.Color.White;
            this.btnPagCategoria.Location = new System.Drawing.Point(12, 261);
            this.btnPagCategoria.Name = "btnPagCategoria";
            this.btnPagCategoria.Size = new System.Drawing.Size(138, 47);
            this.btnPagCategoria.TabIndex = 70;
            this.btnPagCategoria.Text = "Procurar por Categorias";
            this.btnPagCategoria.UseVisualStyleBackColor = false;
            this.btnPagCategoria.Click += new System.EventHandler(this.btnPagCategoria_Click);
            // 
            // btnPagEditar
            // 
            this.btnPagEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagEditar.FlatAppearance.BorderSize = 0;
            this.btnPagEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagEditar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagEditar.ForeColor = System.Drawing.Color.White;
            this.btnPagEditar.Location = new System.Drawing.Point(12, 212);
            this.btnPagEditar.Name = "btnPagEditar";
            this.btnPagEditar.Size = new System.Drawing.Size(138, 43);
            this.btnPagEditar.TabIndex = 69;
            this.btnPagEditar.Text = "Editar";
            this.btnPagEditar.UseVisualStyleBackColor = false;
            this.btnPagEditar.Click += new System.EventHandler(this.btnPagEditar_Click);
            // 
            // btnPagRemover
            // 
            this.btnPagRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagRemover.FlatAppearance.BorderSize = 0;
            this.btnPagRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagRemover.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagRemover.ForeColor = System.Drawing.Color.White;
            this.btnPagRemover.Location = new System.Drawing.Point(12, 167);
            this.btnPagRemover.Name = "btnPagRemover";
            this.btnPagRemover.Size = new System.Drawing.Size(138, 39);
            this.btnPagRemover.TabIndex = 68;
            this.btnPagRemover.Text = "Remover";
            this.btnPagRemover.UseVisualStyleBackColor = false;
            this.btnPagRemover.Click += new System.EventHandler(this.btnPagRemover_Click);
            // 
            // btnPagCadastro
            // 
            this.btnPagCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagCadastro.FlatAppearance.BorderSize = 0;
            this.btnPagCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagCadastro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagCadastro.ForeColor = System.Drawing.Color.White;
            this.btnPagCadastro.Location = new System.Drawing.Point(12, 123);
            this.btnPagCadastro.Name = "btnPagCadastro";
            this.btnPagCadastro.Size = new System.Drawing.Size(138, 37);
            this.btnPagCadastro.TabIndex = 67;
            this.btnPagCadastro.Text = "Cadastrar";
            this.btnPagCadastro.UseVisualStyleBackColor = false;
            this.btnPagCadastro.Click += new System.EventHandler(this.btnPagCadastro_Click);
            // 
            // btnMostrarDelete
            // 
            this.btnMostrarDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostrarDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDelete.FlatAppearance.BorderSize = 0;
            this.btnMostrarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDelete.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDelete.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDelete.Location = new System.Drawing.Point(369, 53);
            this.btnMostrarDelete.Name = "btnMostrarDelete";
            this.btnMostrarDelete.Size = new System.Drawing.Size(124, 28);
            this.btnMostrarDelete.TabIndex = 67;
            this.btnMostrarDelete.Text = "Mostrar";
            this.btnMostrarDelete.UseVisualStyleBackColor = false;
            this.btnMostrarDelete.Click += new System.EventHandler(this.btnMostrarDelete_Click);
            // 
            // tBoxLucro
            // 
            this.tBoxLucro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLucro.Location = new System.Drawing.Point(365, 171);
            this.tBoxLucro.Name = "tBoxLucro";
            this.tBoxLucro.Size = new System.Drawing.Size(124, 23);
            this.tBoxLucro.TabIndex = 69;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(195, 174);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(160, 16);
            this.lblTaxa.TabIndex = 68;
            this.lblTaxa.Text = "Porcentagem de lucro:";
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(542, 177);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(158, 16);
            this.lblFaixa.TabIndex = 70;
            this.lblFaixa.Text = "Informar Faixa Etária";
            // 
            // cBoxFaixa
            // 
            this.cBoxFaixa.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFaixa.FormattingEnabled = true;
            this.cBoxFaixa.Items.AddRange(new object[] {
            "Livre",
            "Maior de 18"});
            this.cBoxFaixa.Location = new System.Drawing.Point(711, 174);
            this.cBoxFaixa.Name = "cBoxFaixa";
            this.cBoxFaixa.Size = new System.Drawing.Size(124, 24);
            this.cBoxFaixa.TabIndex = 71;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(876, 496);
            this.Controls.Add(this.cBoxFaixa);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.tBoxLucro);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.btnMostrarDelete);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGVListar);
            this.Controls.Add(this.cBoxMedida);
            this.Controls.Add(this.tBoxValor);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxMedida;
        private System.Windows.Forms.TextBox tBoxValor;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox picBoxFechar;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Button btnPagCategoria;
        private System.Windows.Forms.Button btnPagEditar;
        private System.Windows.Forms.Button btnPagRemover;
        private System.Windows.Forms.Button btnPagCadastro;
        private System.Windows.Forms.Button btnMostrarDelete;
        private System.Windows.Forms.Label lblTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tBoxLucro;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.ComboBox cBoxFaixa;
    }
}