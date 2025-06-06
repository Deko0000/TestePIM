namespace TestePIM.Telas.Emprestimo
{
    partial class DetalhesEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesEmp));
            this.lblDE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txbISBN = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.psnelCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDevolu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.lblDataDevolvida = new System.Windows.Forms.Label();
            this.dtpDataDevolvida = new System.Windows.Forms.DateTimePicker();
            this.txbValorMulta = new System.Windows.Forms.TextBox();
            this.lblValorMulta = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelLivro.SuspendLayout();
            this.psnelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(161, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(304, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "DADOS DO EMPRÉSTIMO";
            // 
            // btnVoltar
            // 
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblDE);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 106);
            this.panelHeader.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(6, 226);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 20);
            this.lblISBN.TabIndex = 54;
            this.lblISBN.Text = "ISBN:";
            // 
            // txbISBN
            // 
            this.txbISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbISBN.Location = new System.Drawing.Point(11, 250);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(287, 29);
            this.txbISBN.TabIndex = 53;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(6, 153);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 20);
            this.lblAutor.TabIndex = 52;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(11, 178);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(287, 29);
            this.txbAutor.TabIndex = 51;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 83);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 20);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Título:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(11, 108);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(287, 29);
            this.txbTitulo.TabIndex = 49;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(12, 224);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(34, 20);
            this.lblRA.TabIndex = 77;
            this.lblRA.Text = "RA:";
            // 
            // txbRA
            // 
            this.txbRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRA.Location = new System.Drawing.Point(17, 249);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(287, 29);
            this.txbRA.TabIndex = 76;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "E-mail:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(17, 177);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(287, 29);
            this.txbEmail.TabIndex = 74;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 20);
            this.lblNome.TabIndex = 73;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(17, 107);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(287, 29);
            this.txbNome.TabIndex = 72;
            // 
            // panelLivro
            // 
            this.panelLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLivro.Controls.Add(this.label1);
            this.panelLivro.Controls.Add(this.lblTitulo);
            this.panelLivro.Controls.Add(this.txbTitulo);
            this.panelLivro.Controls.Add(this.txbAutor);
            this.panelLivro.Controls.Add(this.lblAutor);
            this.panelLivro.Controls.Add(this.txbISBN);
            this.panelLivro.Controls.Add(this.lblISBN);
            this.panelLivro.Location = new System.Drawing.Point(0, 105);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(318, 343);
            this.panelLivro.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "LIVRO";
            // 
            // psnelCliente
            // 
            this.psnelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psnelCliente.Controls.Add(this.label2);
            this.psnelCliente.Controls.Add(this.lblNome);
            this.psnelCliente.Controls.Add(this.txbNome);
            this.psnelCliente.Controls.Add(this.lblRA);
            this.psnelCliente.Controls.Add(this.txbEmail);
            this.psnelCliente.Controls.Add(this.txbRA);
            this.psnelCliente.Controls.Add(this.lblEmail);
            this.psnelCliente.Location = new System.Drawing.Point(316, 105);
            this.psnelCliente.Name = "psnelCliente";
            this.psnelCliente.Size = new System.Drawing.Size(322, 343);
            this.psnelCliente.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "CLIENTE";
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(472, 499);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(156, 29);
            this.txbStatus.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Devolução Prevista:";
            // 
            // dtpDevolu
            // 
            this.dtpDevolu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolu.Location = new System.Drawing.Point(242, 499);
            this.dtpDevolu.Name = "dtpDevolu";
            this.dtpDevolu.Size = new System.Drawing.Size(200, 29);
            this.dtpDevolu.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Data do Empréstimo:";
            // 
            // dtpEmp
            // 
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(14, 499);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(200, 29);
            this.dtpEmp.TabIndex = 78;
            // 
            // lblDataDevolvida
            // 
            this.lblDataDevolvida.AutoSize = true;
            this.lblDataDevolvida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolvida.Location = new System.Drawing.Point(10, 546);
            this.lblDataDevolvida.Name = "lblDataDevolvida";
            this.lblDataDevolvida.Size = new System.Drawing.Size(144, 20);
            this.lblDataDevolvida.TabIndex = 85;
            this.lblDataDevolvida.Text = "Data da Devolução:";
            // 
            // dtpDataDevolvida
            // 
            this.dtpDataDevolvida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDevolvida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolvida.Location = new System.Drawing.Point(14, 569);
            this.dtpDataDevolvida.Name = "dtpDataDevolvida";
            this.dtpDataDevolvida.Size = new System.Drawing.Size(200, 29);
            this.dtpDataDevolvida.TabIndex = 84;
            // 
            // txbValorMulta
            // 
            this.txbValorMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbValorMulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorMulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorMulta.Location = new System.Drawing.Point(242, 569);
            this.txbValorMulta.Name = "txbValorMulta";
            this.txbValorMulta.Size = new System.Drawing.Size(156, 29);
            this.txbValorMulta.TabIndex = 88;
            // 
            // lblValorMulta
            // 
            this.lblValorMulta.AutoSize = true;
            this.lblValorMulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMulta.Location = new System.Drawing.Point(238, 546);
            this.lblValorMulta.Name = "lblValorMulta";
            this.lblValorMulta.Size = new System.Drawing.Size(115, 20);
            this.lblValorMulta.TabIndex = 89;
            this.lblValorMulta.Text = "Valor da Multa:";
            // 
            // DetalhesEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.txbValorMulta);
            this.Controls.Add(this.lblValorMulta);
            this.Controls.Add(this.lblDataDevolvida);
            this.Controls.Add(this.dtpDataDevolvida);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.psnelCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDevolu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEmp);
            this.Name = "DetalhesEmp";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DetalhesEmp_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLivro.ResumeLayout(false);
            this.panelLivro.PerformLayout();
            this.psnelCliente.ResumeLayout(false);
            this.psnelCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txbISBN;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel psnelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDevolu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.Label lblDataDevolvida;
        private System.Windows.Forms.DateTimePicker dtpDataDevolvida;
        private System.Windows.Forms.TextBox txbValorMulta;
        private System.Windows.Forms.Label lblValorMulta;
    }
}