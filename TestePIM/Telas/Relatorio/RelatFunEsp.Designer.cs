namespace TestePIM.Telas.Relatorio
{
    partial class RelatFunEsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatFunEsp));
            this.panelInfEmp = new System.Windows.Forms.Panel();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txbMulta = new System.Windows.Forms.TextBox();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDevoluPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtpDaDevolu = new System.Windows.Forms.DateTimePicker();
            this.lblDataDevolu = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.panelInfPessoal = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.cbxBuscaLivro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDE = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnBuscaFun = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblQuantEmp = new System.Windows.Forms.Label();
            this.lblQuantMulta = new System.Windows.Forms.Label();
            this.panelInfEmp.SuspendLayout();
            this.panelInfPessoal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfEmp
            // 
            this.panelInfEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfEmp.Controls.Add(this.lblQuantMulta);
            this.panelInfEmp.Controls.Add(this.lblMulta);
            this.panelInfEmp.Controls.Add(this.txbMulta);
            this.panelInfEmp.Controls.Add(this.lblQuantEmp);
            this.panelInfEmp.Controls.Add(this.lblDataEmp);
            this.panelInfEmp.Controls.Add(this.dtpEmp);
            this.panelInfEmp.Controls.Add(this.label2);
            this.panelInfEmp.Controls.Add(this.dtpDevoluPrevista);
            this.panelInfEmp.Controls.Add(this.dtpDaDevolu);
            this.panelInfEmp.Controls.Add(this.lblDataDevolu);
            this.panelInfEmp.Controls.Add(this.lblStatus);
            this.panelInfEmp.Controls.Add(this.txbStatus);
            this.panelInfEmp.Location = new System.Drawing.Point(8, 344);
            this.panelInfEmp.Name = "panelInfEmp";
            this.panelInfEmp.Size = new System.Drawing.Size(381, 209);
            this.panelInfEmp.TabIndex = 141;
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulta.Location = new System.Drawing.Point(213, 123);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(48, 17);
            this.lblMulta.TabIndex = 129;
            this.lblMulta.Text = "Multa:";
            // 
            // txbMulta
            // 
            this.txbMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbMulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMulta.Location = new System.Drawing.Point(216, 143);
            this.txbMulta.Name = "txbMulta";
            this.txbMulta.ReadOnly = true;
            this.txbMulta.Size = new System.Drawing.Size(118, 25);
            this.txbMulta.TabIndex = 128;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(13, 13);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(139, 17);
            this.lblDataEmp.TabIndex = 108;
            this.lblDataEmp.Text = "Data do Empréstimo:";
            // 
            // dtpEmp
            // 
            this.dtpEmp.Enabled = false;
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(17, 36);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(178, 25);
            this.dtpEmp.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 125;
            this.label2.Text = "Data da Devolução:";
            // 
            // dtpDevoluPrevista
            // 
            this.dtpDevoluPrevista.Enabled = false;
            this.dtpDevoluPrevista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevoluPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevoluPrevista.Location = new System.Drawing.Point(217, 36);
            this.dtpDevoluPrevista.Name = "dtpDevoluPrevista";
            this.dtpDevoluPrevista.Size = new System.Drawing.Size(154, 25);
            this.dtpDevoluPrevista.TabIndex = 109;
            // 
            // dtpDaDevolu
            // 
            this.dtpDaDevolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDaDevolu.Enabled = false;
            this.dtpDaDevolu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDaDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDaDevolu.Location = new System.Drawing.Point(17, 92);
            this.dtpDaDevolu.Name = "dtpDaDevolu";
            this.dtpDaDevolu.Size = new System.Drawing.Size(178, 25);
            this.dtpDaDevolu.TabIndex = 124;
            // 
            // lblDataDevolu
            // 
            this.lblDataDevolu.AutoSize = true;
            this.lblDataDevolu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolu.Location = new System.Drawing.Point(213, 13);
            this.lblDataDevolu.Name = "lblDataDevolu";
            this.lblDataDevolu.Size = new System.Drawing.Size(130, 17);
            this.lblDataDevolu.TabIndex = 110;
            this.lblDataDevolu.Text = "Devolução Prevista:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(213, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.TabIndex = 111;
            this.lblStatus.Text = "Status:";
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(216, 92);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(118, 25);
            this.txbStatus.TabIndex = 107;
            // 
            // panelInfPessoal
            // 
            this.panelInfPessoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfPessoal.Controls.Add(this.lblEndereco);
            this.panelInfPessoal.Controls.Add(this.lblNome);
            this.panelInfPessoal.Controls.Add(this.label3);
            this.panelInfPessoal.Controls.Add(this.lblEmail);
            this.panelInfPessoal.Controls.Add(this.dtpDataNasc);
            this.panelInfPessoal.Controls.Add(this.txbNome);
            this.panelInfPessoal.Controls.Add(this.btnBuscaFun);
            this.panelInfPessoal.Controls.Add(this.lblMatricula);
            this.panelInfPessoal.Controls.Add(this.lblCpf);
            this.panelInfPessoal.Location = new System.Drawing.Point(8, 188);
            this.panelInfPessoal.Name = "panelInfPessoal";
            this.panelInfPessoal.Size = new System.Drawing.Size(381, 135);
            this.panelInfPessoal.TabIndex = 140;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 116;
            this.lblNome.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "Data de Nascimento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(211, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 118;
            this.lblEmail.Text = "E-mail";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Enabled = false;
            this.dtpDataNasc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(11, 103);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(179, 25);
            this.dtpDataNasc.TabIndex = 129;
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(11, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(287, 25);
            this.txbNome.TabIndex = 115;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(211, 80);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(66, 17);
            this.lblMatricula.TabIndex = 128;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(8, 59);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 17);
            this.lblCpf.TabIndex = 126;
            this.lblCpf.Text = "CPF";
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(409, 193);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 284);
            this.panelLivro.TabIndex = 139;
            // 
            // cbxBuscaLivro
            // 
            this.cbxBuscaLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxBuscaLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscaLivro.FormattingEnabled = true;
            this.cbxBuscaLivro.Location = new System.Drawing.Point(409, 157);
            this.cbxBuscaLivro.Name = "cbxBuscaLivro";
            this.cbxBuscaLivro.Size = new System.Drawing.Size(213, 29);
            this.cbxBuscaLivro.TabIndex = 138;
            this.cbxBuscaLivro.Click += new System.EventHandler(this.cbxBuscaLivro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 137;
            this.label1.Text = "Emprestimos Feitos:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(89, 146);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(239, 25);
            this.lblCliente.TabIndex = 136;
            this.lblCliente.Text = "BUSCA DE FUNCIONÁRIO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(446, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 135;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(427, 500);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(178, 36);
            this.btnConfirmar.TabIndex = 134;
            this.btnConfirmar.Text = "CONFIRMAR RELATÓRIO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblDE);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 106);
            this.panelHeader.TabIndex = 133;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(119, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(389, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "RELATÓRIO PARA FUNCIONÁRIO";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(211, 103);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(64, 17);
            this.lblEndereco.TabIndex = 132;
            this.lblEndereco.Text = "Endereço";
            // 
            // btnBuscaFun
            // 
            this.btnBuscaFun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaFun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaFun.FlatAppearance.BorderSize = 0;
            this.btnBuscaFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaFun.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaFun.Image")));
            this.btnBuscaFun.Location = new System.Drawing.Point(316, 17);
            this.btnBuscaFun.Name = "btnBuscaFun";
            this.btnBuscaFun.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaFun.TabIndex = 120;
            this.btnBuscaFun.UseVisualStyleBackColor = false;
            this.btnBuscaFun.Click += new System.EventHandler(this.btnBuscaFun_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(3, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 79;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblQuantEmp
            // 
            this.lblQuantEmp.AutoSize = true;
            this.lblQuantEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantEmp.Location = new System.Drawing.Point(14, 133);
            this.lblQuantEmp.Name = "lblQuantEmp";
            this.lblQuantEmp.Size = new System.Drawing.Size(183, 17);
            this.lblQuantEmp.TabIndex = 127;
            this.lblQuantEmp.Text = "Quantidade de Empréstimos";
            // 
            // lblQuantMulta
            // 
            this.lblQuantMulta.AutoSize = true;
            this.lblQuantMulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantMulta.Location = new System.Drawing.Point(14, 172);
            this.lblQuantMulta.Name = "lblQuantMulta";
            this.lblQuantMulta.Size = new System.Drawing.Size(145, 17);
            this.lblQuantMulta.TabIndex = 132;
            this.lblQuantMulta.Text = "Quantidade de Multas";
            // 
            // RelatFunEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelInfEmp);
            this.Controls.Add(this.panelInfPessoal);
            this.Controls.Add(this.panelLivro);
            this.Controls.Add(this.cbxBuscaLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatFunEsp";
            this.Text = "RelatFunEsp";
            this.panelInfEmp.ResumeLayout(false);
            this.panelInfEmp.PerformLayout();
            this.panelInfPessoal.ResumeLayout(false);
            this.panelInfPessoal.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfEmp;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txbMulta;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDevoluPrevista;
        private System.Windows.Forms.DateTimePicker dtpDaDevolu;
        private System.Windows.Forms.Label lblDataDevolu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Panel panelInfPessoal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnBuscaFun;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.ComboBox cbxBuscaLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblQuantMulta;
        private System.Windows.Forms.Label lblQuantEmp;
    }
}