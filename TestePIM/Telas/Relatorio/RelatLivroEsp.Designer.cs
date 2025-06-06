namespace TestePIM.Telas.Relatorio
{
    partial class RelatLivroEsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatLivroEsp));
            this.panelInfEmp = new System.Windows.Forms.Panel();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txbMulta = new System.Windows.Forms.TextBox();
            this.lblQuantEmp = new System.Windows.Forms.Label();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDevoluPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtpDaDevolu = new System.Windows.Forms.DateTimePicker();
            this.lblDataDevolu = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.panelInfPessoal = new System.Windows.Forms.Panel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDataPubli = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.cbxBuscaLivro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDE = new System.Windows.Forms.Label();
            this.btnBuscaFun = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelInfEmp.SuspendLayout();
            this.panelInfPessoal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfEmp
            // 
            this.panelInfEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panelInfEmp.Location = new System.Drawing.Point(9, 338);
            this.panelInfEmp.Name = "panelInfEmp";
            this.panelInfEmp.Size = new System.Drawing.Size(381, 192);
            this.panelInfEmp.TabIndex = 150;
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
            // lblQuantEmp
            // 
            this.lblQuantEmp.AutoSize = true;
            this.lblQuantEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantEmp.Location = new System.Drawing.Point(14, 145);
            this.lblQuantEmp.Name = "lblQuantEmp";
            this.lblQuantEmp.Size = new System.Drawing.Size(183, 17);
            this.lblQuantEmp.TabIndex = 127;
            this.lblQuantEmp.Text = "Quantidade de Empréstimos";
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
            this.panelInfPessoal.Controls.Add(this.lblISBN);
            this.panelInfPessoal.Controls.Add(this.lblTitulo);
            this.panelInfPessoal.Controls.Add(this.lblDataPubli);
            this.panelInfPessoal.Controls.Add(this.lblGenero);
            this.panelInfPessoal.Controls.Add(this.txbTitulo);
            this.panelInfPessoal.Controls.Add(this.btnBuscaFun);
            this.panelInfPessoal.Controls.Add(this.lblQuant);
            this.panelInfPessoal.Controls.Add(this.lblAutor);
            this.panelInfPessoal.Location = new System.Drawing.Point(9, 182);
            this.panelInfPessoal.Name = "panelInfPessoal";
            this.panelInfPessoal.Size = new System.Drawing.Size(381, 135);
            this.panelInfPessoal.TabIndex = 149;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(211, 103);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(37, 17);
            this.lblISBN.TabIndex = 132;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 17);
            this.lblTitulo.TabIndex = 116;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblDataPubli
            // 
            this.lblDataPubli.AutoSize = true;
            this.lblDataPubli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPubli.Location = new System.Drawing.Point(12, 94);
            this.lblDataPubli.Name = "lblDataPubli";
            this.lblDataPubli.Size = new System.Drawing.Size(122, 17);
            this.lblDataPubli.TabIndex = 130;
            this.lblDataPubli.Text = "Ano de Publicação";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(211, 59);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 17);
            this.lblGenero.TabIndex = 118;
            this.lblGenero.Text = "Gênero";
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(11, 30);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(287, 25);
            this.txbTitulo.TabIndex = 115;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(211, 80);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(80, 17);
            this.lblQuant.TabIndex = 128;
            this.lblQuant.Text = "Quantidade";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(9, 68);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 17);
            this.lblAutor.TabIndex = 126;
            this.lblAutor.Text = "Autor";
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(409, 204);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 284);
            this.panelLivro.TabIndex = 148;
            // 
            // cbxBuscaLivro
            // 
            this.cbxBuscaLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxBuscaLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscaLivro.FormattingEnabled = true;
            this.cbxBuscaLivro.Location = new System.Drawing.Point(409, 168);
            this.cbxBuscaLivro.Name = "cbxBuscaLivro";
            this.cbxBuscaLivro.Size = new System.Drawing.Size(213, 29);
            this.cbxBuscaLivro.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 146;
            this.label1.Text = "Emprestimos Feitos:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(121, 140);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(163, 25);
            this.lblCliente.TabIndex = 145;
            this.lblCliente.Text = "BUSCA DE LIVRO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(343, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 144;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(123, 560);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(178, 36);
            this.btnConfirmar.TabIndex = 143;
            this.btnConfirmar.Text = "CONFIRMAR RELATÓRIO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
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
            this.panelHeader.TabIndex = 142;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(165, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(292, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "RELATÓRIO PARA LIVRO";
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
            // 
            // RelatLivroEsp
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
            this.Name = "RelatLivroEsp";
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
        private System.Windows.Forms.Label lblQuantEmp;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDevoluPrevista;
        private System.Windows.Forms.DateTimePicker dtpDaDevolu;
        private System.Windows.Forms.Label lblDataDevolu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Panel panelInfPessoal;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDataPubli;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Button btnBuscaFun;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.ComboBox cbxBuscaLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
    }
}