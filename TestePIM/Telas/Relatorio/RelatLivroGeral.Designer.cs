namespace TestePIM.Telas.Relatorio
{
    partial class RelatLivroGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatLivroGeral));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDE = new System.Windows.Forms.Label();
            this.lblLME = new System.Windows.Forms.Label();
            this.txbLivMaisEmp = new System.Windows.Forms.TextBox();
            this.lblAMP = new System.Windows.Forms.Label();
            this.txbAutMaisPopular = new System.Windows.Forms.TextBox();
            this.lblGMP = new System.Windows.Forms.Label();
            this.txbGenMaisPopular = new System.Windows.Forms.TextBox();
            this.lblQE = new System.Windows.Forms.Label();
            this.txbQuantEmp = new System.Windows.Forms.TextBox();
            this.lblQM = new System.Windows.Forms.Label();
            this.txbQuantMultas = new System.Windows.Forms.TextBox();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.lblCapaLiv = new System.Windows.Forms.Label();
            this.btnBuscaInf = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
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
            this.panelHeader.TabIndex = 143;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(196, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(234, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "RELATÓRIO LIVROS";
            // 
            // lblLME
            // 
            this.lblLME.AutoSize = true;
            this.lblLME.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLME.Location = new System.Drawing.Point(37, 192);
            this.lblLME.Name = "lblLME";
            this.lblLME.Size = new System.Drawing.Size(153, 17);
            this.lblLME.TabIndex = 145;
            this.lblLME.Text = "Livro Mais Emprestado:";
            // 
            // txbLivMaisEmp
            // 
            this.txbLivMaisEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbLivMaisEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLivMaisEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLivMaisEmp.Location = new System.Drawing.Point(40, 212);
            this.txbLivMaisEmp.Name = "txbLivMaisEmp";
            this.txbLivMaisEmp.Size = new System.Drawing.Size(287, 25);
            this.txbLivMaisEmp.TabIndex = 144;
            // 
            // lblAMP
            // 
            this.lblAMP.AutoSize = true;
            this.lblAMP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMP.Location = new System.Drawing.Point(37, 253);
            this.lblAMP.Name = "lblAMP";
            this.lblAMP.Size = new System.Drawing.Size(133, 17);
            this.lblAMP.TabIndex = 147;
            this.lblAMP.Text = "Autor Mais Popular:";
            // 
            // txbAutMaisPopular
            // 
            this.txbAutMaisPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAutMaisPopular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutMaisPopular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutMaisPopular.Location = new System.Drawing.Point(40, 273);
            this.txbAutMaisPopular.Name = "txbAutMaisPopular";
            this.txbAutMaisPopular.Size = new System.Drawing.Size(287, 25);
            this.txbAutMaisPopular.TabIndex = 146;
            // 
            // lblGMP
            // 
            this.lblGMP.AutoSize = true;
            this.lblGMP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMP.Location = new System.Drawing.Point(37, 314);
            this.lblGMP.Name = "lblGMP";
            this.lblGMP.Size = new System.Drawing.Size(142, 17);
            this.lblGMP.TabIndex = 149;
            this.lblGMP.Text = "Gênero Mais Popular:";
            // 
            // txbGenMaisPopular
            // 
            this.txbGenMaisPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbGenMaisPopular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGenMaisPopular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenMaisPopular.Location = new System.Drawing.Point(40, 334);
            this.txbGenMaisPopular.Name = "txbGenMaisPopular";
            this.txbGenMaisPopular.Size = new System.Drawing.Size(287, 25);
            this.txbGenMaisPopular.TabIndex = 148;
            // 
            // lblQE
            // 
            this.lblQE.AutoSize = true;
            this.lblQE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQE.Location = new System.Drawing.Point(37, 380);
            this.lblQE.Name = "lblQE";
            this.lblQE.Size = new System.Drawing.Size(187, 17);
            this.lblQE.TabIndex = 151;
            this.lblQE.Text = "Quantidade de Empréstimos:";
            // 
            // txbQuantEmp
            // 
            this.txbQuantEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbQuantEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuantEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantEmp.Location = new System.Drawing.Point(40, 400);
            this.txbQuantEmp.Name = "txbQuantEmp";
            this.txbQuantEmp.Size = new System.Drawing.Size(287, 25);
            this.txbQuantEmp.TabIndex = 150;
            // 
            // lblQM
            // 
            this.lblQM.AutoSize = true;
            this.lblQM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQM.Location = new System.Drawing.Point(37, 444);
            this.lblQM.Name = "lblQM";
            this.lblQM.Size = new System.Drawing.Size(149, 17);
            this.lblQM.TabIndex = 153;
            this.lblQM.Text = "Quantidade de Multas:";
            // 
            // txbQuantMultas
            // 
            this.txbQuantMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbQuantMultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuantMultas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantMultas.Location = new System.Drawing.Point(40, 464);
            this.txbQuantMultas.Name = "txbQuantMultas";
            this.txbQuantMultas.Size = new System.Drawing.Size(287, 25);
            this.txbQuantMultas.TabIndex = 152;
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(387, 212);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 284);
            this.panelLivro.TabIndex = 154;
            // 
            // lblCapaLiv
            // 
            this.lblCapaLiv.AutoSize = true;
            this.lblCapaLiv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapaLiv.Location = new System.Drawing.Point(384, 192);
            this.lblCapaLiv.Name = "lblCapaLiv";
            this.lblCapaLiv.Size = new System.Drawing.Size(187, 17);
            this.lblCapaLiv.TabIndex = 155;
            this.lblCapaLiv.Text = "Livro Mais Emprestado Capa:";
            // 
            // btnBuscaInf
            // 
            this.btnBuscaInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaInf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaInf.FlatAppearance.BorderSize = 0;
            this.btnBuscaInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaInf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBuscaInf.Location = new System.Drawing.Point(180, 128);
            this.btnBuscaInf.Name = "btnBuscaInf";
            this.btnBuscaInf.Size = new System.Drawing.Size(263, 36);
            this.btnBuscaInf.TabIndex = 156;
            this.btnBuscaInf.Text = "BUSCAR INFORMAÇÕES";
            this.btnBuscaInf.UseVisualStyleBackColor = false;
            this.btnBuscaInf.Click += new System.EventHandler(this.btnBuscaInf_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(356, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 158;
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
            this.btnConfirmar.Location = new System.Drawing.Point(130, 546);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(178, 36);
            this.btnConfirmar.TabIndex = 157;
            this.btnConfirmar.Text = "CONFIRMAR RELATÓRIO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
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
            // RelatLivroGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnBuscaInf);
            this.Controls.Add(this.lblCapaLiv);
            this.Controls.Add(this.panelLivro);
            this.Controls.Add(this.lblQM);
            this.Controls.Add(this.txbQuantMultas);
            this.Controls.Add(this.lblQE);
            this.Controls.Add(this.txbQuantEmp);
            this.Controls.Add(this.lblGMP);
            this.Controls.Add(this.txbGenMaisPopular);
            this.Controls.Add(this.lblAMP);
            this.Controls.Add(this.txbAutMaisPopular);
            this.Controls.Add(this.lblLME);
            this.Controls.Add(this.txbLivMaisEmp);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatLivroGeral";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblLME;
        private System.Windows.Forms.TextBox txbLivMaisEmp;
        private System.Windows.Forms.Label lblAMP;
        private System.Windows.Forms.TextBox txbAutMaisPopular;
        private System.Windows.Forms.Label lblGMP;
        private System.Windows.Forms.TextBox txbGenMaisPopular;
        private System.Windows.Forms.Label lblQE;
        private System.Windows.Forms.TextBox txbQuantEmp;
        private System.Windows.Forms.Label lblQM;
        private System.Windows.Forms.TextBox txbQuantMultas;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.Label lblCapaLiv;
        private System.Windows.Forms.Button btnBuscaInf;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}