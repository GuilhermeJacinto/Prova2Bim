namespace Stonks_Cliente.Forms.Perfil
{
    partial class FormLoginCliente
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
            this.tBoxSenhaLog = new System.Windows.Forms.TextBox();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.btnLogCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForms = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tBoxSenhaLog
            // 
            this.tBoxSenhaLog.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSenhaLog.Location = new System.Drawing.Point(257, 115);
            this.tBoxSenhaLog.Name = "tBoxSenhaLog";
            this.tBoxSenhaLog.Size = new System.Drawing.Size(136, 27);
            this.tBoxSenhaLog.TabIndex = 100;
            this.tBoxSenhaLog.TextChanged += new System.EventHandler(this.tBoxSenhaLog_TextChanged);
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLogin.Location = new System.Drawing.Point(257, 67);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(136, 27);
            this.tBoxLogin.TabIndex = 99;
            this.tBoxLogin.TextChanged += new System.EventHandler(this.tBoxLogin_TextChanged);
            // 
            // btnLogCliente
            // 
            this.btnLogCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogCliente.FlatAppearance.BorderSize = 0;
            this.btnLogCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogCliente.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCliente.ForeColor = System.Drawing.Color.White;
            this.btnLogCliente.Location = new System.Drawing.Point(244, 172);
            this.btnLogCliente.Name = "btnLogCliente";
            this.btnLogCliente.Size = new System.Drawing.Size(156, 72);
            this.btnLogCliente.TabIndex = 98;
            this.btnLogCliente.Text = "Logar";
            this.btnLogCliente.UseVisualStyleBackColor = false;
            this.btnLogCliente.Click += new System.EventHandler(this.btnLogCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 97;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Login:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Já sou cliente Stonks:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(671, 316);
            this.panelForms.TabIndex = 101;
            // 
            // FormLoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 316);
            this.Controls.Add(this.tBoxSenhaLog);
            this.Controls.Add(this.tBoxLogin);
            this.Controls.Add(this.btnLogCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelForms);
            this.Name = "FormLoginCliente";
            this.Text = "FormCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBoxSenhaLog;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.Button btnLogCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelForms;
    }
}