namespace TestePIM.Telas
{
    partial class VerDadosFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDadosFuncionario));
            this.cbxMostraSenha = new System.Windows.Forms.CheckBox();
            this.lblIdentificaFuncionario = new System.Windows.Forms.Label();
            this.lblIF = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMostraSenha
            // 
            this.cbxMostraSenha.AutoSize = true;
            this.cbxMostraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.cbxMostraSenha.Location = new System.Drawing.Point(619, 288);
            this.cbxMostraSenha.Name = "cbxMostraSenha";
            this.cbxMostraSenha.Size = new System.Drawing.Size(15, 14);
            this.cbxMostraSenha.TabIndex = 109;
            this.cbxMostraSenha.UseVisualStyleBackColor = false;
            this.cbxMostraSenha.CheckedChanged += new System.EventHandler(this.cbxMostraSenha_CheckedChanged);
            // 
            // lblIdentificaFuncionario
            // 
            this.lblIdentificaFuncionario.AutoSize = true;
            this.lblIdentificaFuncionario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificaFuncionario.Location = new System.Drawing.Point(324, 353);
            this.lblIdentificaFuncionario.Name = "lblIdentificaFuncionario";
            this.lblIdentificaFuncionario.Size = new System.Drawing.Size(174, 20);
            this.lblIdentificaFuncionario.TabIndex = 108;
            this.lblIdentificaFuncionario.Text = "lblIdentificaFuncionario";
            // 
            // lblIF
            // 
            this.lblIF.AutoSize = true;
            this.lblIF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIF.Location = new System.Drawing.Point(323, 323);
            this.lblIF.Name = "lblIF";
            this.lblIF.Size = new System.Drawing.Size(187, 20);
            this.lblIF.TabIndex = 107;
            this.lblIF.Text = "Matrícula do Funcionário:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(327, 208);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(287, 29);
            this.txbEmail.TabIndex = 106;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.dtpDataNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNasc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(250, 426);
            this.dtpDataNasc.MaxDate = new System.DateTime(2025, 5, 30, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(150, 27);
            this.dtpDataNasc.TabIndex = 103;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(16, 323);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 20);
            this.lblEndereco.TabIndex = 101;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(21, 347);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(287, 29);
            this.txbEndereco.TabIndex = 100;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(322, 254);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 20);
            this.lblSenha.TabIndex = 99;
            this.lblSenha.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(326, 279);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(287, 29);
            this.txbSenha.TabIndex = 98;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(245, 402);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(155, 20);
            this.lblDataNasc.TabIndex = 97;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(6, -1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 53);
            this.btnVoltar.TabIndex = 95;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(16, 256);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 20);
            this.lblCPF.TabIndex = 94;
            this.lblCPF.Text = "CPF:";
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(21, 280);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(287, 29);
            this.txbCPF.TabIndex = 93;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(322, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 92;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(17, 184);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 20);
            this.lblNome.TabIndex = 91;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(21, 209);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(287, 29);
            this.txbNome.TabIndex = 90;
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF.Location = new System.Drawing.Point(178, 84);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(306, 37);
            this.lblCF.TabIndex = 89;
            this.lblCF.Text = "DADOS FUNCIONÁRIO";
            // 
            // VerDadosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.cbxMostraSenha);
            this.Controls.Add(this.lblIdentificaFuncionario);
            this.Controls.Add(this.lblIF);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCF);
            this.Name = "VerDadosFuncionario";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormVerDadosFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxMostraSenha;
        private System.Windows.Forms.Label lblIdentificaFuncionario;
        private System.Windows.Forms.Label lblIF;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCF;
    }
}