namespace TestePIM.Telas.Emprestimo
{
    partial class RealizaEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizaEmp));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblRE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbLivro = new System.Windows.Forms.TextBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.btnBuscaLivro = new System.Windows.Forms.Button();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblCapa = new System.Windows.Forms.Label();
            this.pbxCapa = new System.Windows.Forms.PictureBox();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.lblValorEmp = new System.Windows.Forms.Label();
            this.txbValorEmp = new System.Windows.Forms.TextBox();
=======
            this.txbValorEmp = new System.Windows.Forms.TextBox();
            this.lblValorEmp = new System.Windows.Forms.Label();
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblRE);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 181);
            this.panelHeader.TabIndex = 1;
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblRE.Location = new System.Drawing.Point(149, 74);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(326, 37);
            this.lblRE.TabIndex = 80;
            this.lblRE.Text = "REALIZAR EMPRÉSTIMO";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(10, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 79;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbLivro
            // 
            this.txbLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLivro.Location = new System.Drawing.Point(30, 218);
            this.txbLivro.Name = "txbLivro";
            this.txbLivro.Size = new System.Drawing.Size(335, 29);
            this.txbLivro.TabIndex = 2;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(26, 194);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(52, 21);
            this.lblLivro.TabIndex = 3;
            this.lblLivro.Text = "Livro:";
            // 
            // btnBuscaLivro
            // 
            this.btnBuscaLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaLivro.FlatAppearance.BorderSize = 0;
            this.btnBuscaLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaLivro.Image")));
            this.btnBuscaLivro.Location = new System.Drawing.Point(371, 209);
            this.btnBuscaLivro.Name = "btnBuscaLivro";
            this.btnBuscaLivro.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaLivro.TabIndex = 4;
            this.btnBuscaLivro.UseVisualStyleBackColor = false;
            this.btnBuscaLivro.Click += new System.EventHandler(this.btnBuscaLivro_Click);
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpEmprestimo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmprestimo.Location = new System.Drawing.Point(30, 480);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpEmprestimo.Size = new System.Drawing.Size(165, 33);
            this.dtpEmprestimo.TabIndex = 5;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(26, 254);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(58, 21);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(30, 278);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(335, 29);
            this.txbAutor.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(26, 314);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 21);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente:";
            // 
            // txbCliente
            // 
            this.txbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(30, 338);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(335, 29);
            this.txbCliente.TabIndex = 8;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(26, 374);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(35, 21);
            this.lblRA.TabIndex = 11;
            this.lblRA.Text = "RA:";
            // 
            // txbRA
            // 
            this.txbRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRA.Location = new System.Drawing.Point(30, 398);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(335, 29);
            this.txbRA.TabIndex = 10;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(371, 329);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaCliente.TabIndex = 12;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(433, 194);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(52, 21);
            this.lblCapa.TabIndex = 13;
            this.lblCapa.Text = "Capa:";
            // 
            // pbxCapa
            // 
            this.pbxCapa.Location = new System.Drawing.Point(437, 218);
            this.pbxCapa.Name = "pbxCapa";
            this.pbxCapa.Size = new System.Drawing.Size(174, 209);
            this.pbxCapa.TabIndex = 14;
            this.pbxCapa.TabStop = false;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(26, 456);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(169, 21);
            this.lblDataEmp.TabIndex = 15;
            this.lblDataEmp.Text = "Data de Empréstimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de Devolução:";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(239, 480);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDevolucao.Size = new System.Drawing.Size(165, 33);
            this.dtpDevolucao.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(30, 550);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(165, 38);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(448, 550);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 38);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
<<<<<<< HEAD
            this.btnPagar.Location = new System.Drawing.Point(240, 550);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(163, 38);
            this.btnPagar.TabIndex = 20;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
=======
            this.btnPagar.Location = new System.Drawing.Point(239, 550);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(165, 38);
            this.btnPagar.TabIndex = 20;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txbValorEmp
            // 
            this.txbValorEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbValorEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorEmp.Location = new System.Drawing.Point(448, 480);
            this.txbValorEmp.Name = "txbValorEmp";
            this.txbValorEmp.ReadOnly = true;
            this.txbValorEmp.Size = new System.Drawing.Size(163, 33);
            this.txbValorEmp.TabIndex = 107;
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
            // 
            // lblValorEmp
            // 
            this.lblValorEmp.AutoSize = true;
            this.lblValorEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblValorEmp.Location = new System.Drawing.Point(433, 470);
            this.lblValorEmp.Name = "lblValorEmp";
            this.lblValorEmp.Size = new System.Drawing.Size(173, 21);
            this.lblValorEmp.TabIndex = 22;
            this.lblValorEmp.Text = "Valor de Empréstimo:";
            // 
            // txbValorEmp
            // 
            this.txbValorEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorEmp.Location = new System.Drawing.Point(437, 494);
            this.txbValorEmp.Name = "txbValorEmp";
            this.txbValorEmp.ReadOnly = true;
            this.txbValorEmp.Size = new System.Drawing.Size(174, 29);
            this.txbValorEmp.TabIndex = 21;
=======
            this.lblValorEmp.Location = new System.Drawing.Point(444, 456);
            this.lblValorEmp.Name = "lblValorEmp";
            this.lblValorEmp.Size = new System.Drawing.Size(174, 21);
            this.lblValorEmp.TabIndex = 108;
            this.lblValorEmp.Text = "Valor do Empréstimo:";
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
            // 
            // RealizaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(638, 619);
<<<<<<< HEAD
            this.Controls.Add(this.lblValorEmp);
            this.Controls.Add(this.txbValorEmp);
=======
            this.Controls.Add(this.txbValorEmp);
            this.Controls.Add(this.lblValorEmp);
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.lblDataEmp);
            this.Controls.Add(this.pbxCapa);
            this.Controls.Add(this.lblCapa);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.dtpEmprestimo);
            this.Controls.Add(this.btnBuscaLivro);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.txbLivro);
            this.Controls.Add(this.panelHeader);
            this.Name = "RealizaEmp";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.RealizaEmp_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbLivro;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Button btnBuscaLivro;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.PictureBox pbxCapa;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
<<<<<<< HEAD
        private System.Windows.Forms.Label lblValorEmp;
        private System.Windows.Forms.TextBox txbValorEmp;
=======
        private System.Windows.Forms.TextBox txbValorEmp;
        private System.Windows.Forms.Label lblValorEmp;
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
    }
}