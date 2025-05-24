namespace TestePIM.Telas
{
    partial class DadosLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosLivro));
            this.panelDadosLivro = new System.Windows.Forms.Panel();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.btnRealizaEmp = new System.Windows.Forms.Button();
            this.txbSinopse = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.txbAnoPubli = new System.Windows.Forms.TextBox();
            this.nUpDownQuant = new System.Windows.Forms.NumericUpDown();
            this.lblQntEstoque = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCapa = new System.Windows.Forms.Label();
            this.lblAnoPubli = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txbISBN = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.pbxCapa = new System.Windows.Forms.PictureBox();
            this.lblCL = new System.Windows.Forms.Label();
            this.panelDadosLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDadosLivro
            // 
            this.panelDadosLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panelDadosLivro.Controls.Add(this.txbGenero);
            this.panelDadosLivro.Controls.Add(this.btnRealizaEmp);
            this.panelDadosLivro.Controls.Add(this.txbSinopse);
            this.panelDadosLivro.Controls.Add(this.lblSinopse);
            this.panelDadosLivro.Controls.Add(this.txbAnoPubli);
            this.panelDadosLivro.Controls.Add(this.nUpDownQuant);
            this.panelDadosLivro.Controls.Add(this.lblQntEstoque);
            this.panelDadosLivro.Controls.Add(this.btnEditar);
            this.panelDadosLivro.Controls.Add(this.btnVoltar);
            this.panelDadosLivro.Controls.Add(this.lblCapa);
            this.panelDadosLivro.Controls.Add(this.lblAnoPubli);
            this.panelDadosLivro.Controls.Add(this.lblGenero);
            this.panelDadosLivro.Controls.Add(this.lblISBN);
            this.panelDadosLivro.Controls.Add(this.txbISBN);
            this.panelDadosLivro.Controls.Add(this.lblAutor);
            this.panelDadosLivro.Controls.Add(this.txbAutor);
            this.panelDadosLivro.Controls.Add(this.lblTitulo);
            this.panelDadosLivro.Controls.Add(this.txbTitulo);
            this.panelDadosLivro.Controls.Add(this.pbxCapa);
            this.panelDadosLivro.Controls.Add(this.lblCL);
            this.panelDadosLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDadosLivro.Location = new System.Drawing.Point(0, 0);
            this.panelDadosLivro.Name = "panelDadosLivro";
            this.panelDadosLivro.Size = new System.Drawing.Size(638, 619);
            this.panelDadosLivro.TabIndex = 0;
            // 
            // txbGenero
            // 
            this.txbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenero.Location = new System.Drawing.Point(39, 342);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(217, 29);
            this.txbGenero.TabIndex = 61;
            // 
            // btnRealizaEmp
            // 
            this.btnRealizaEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnRealizaEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizaEmp.FlatAppearance.BorderSize = 0;
            this.btnRealizaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizaEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnRealizaEmp.Location = new System.Drawing.Point(39, 561);
            this.btnRealizaEmp.Name = "btnRealizaEmp";
            this.btnRealizaEmp.Size = new System.Drawing.Size(242, 40);
            this.btnRealizaEmp.TabIndex = 60;
            this.btnRealizaEmp.Text = "REALIZAR EMPRÉSTIMO";
            this.btnRealizaEmp.UseVisualStyleBackColor = false;
            this.btnRealizaEmp.Click += new System.EventHandler(this.btnRealizaEmp_Click);
            // 
            // txbSinopse
            // 
            this.txbSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbSinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSinopse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSinopse.Location = new System.Drawing.Point(344, 411);
            this.txbSinopse.Multiline = true;
            this.txbSinopse.Name = "txbSinopse";
            this.txbSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSinopse.Size = new System.Drawing.Size(287, 150);
            this.txbSinopse.TabIndex = 59;
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(340, 388);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(67, 20);
            this.lblSinopse.TabIndex = 58;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // txbAnoPubli
            // 
            this.txbAnoPubli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAnoPubli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnoPubli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnoPubli.Location = new System.Drawing.Point(39, 416);
            this.txbAnoPubli.Name = "txbAnoPubli";
            this.txbAnoPubli.Size = new System.Drawing.Size(217, 29);
            this.txbAnoPubli.TabIndex = 56;
            // 
            // nUpDownQuant
            // 
            this.nUpDownQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.nUpDownQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpDownQuant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownQuant.Location = new System.Drawing.Point(136, 462);
            this.nUpDownQuant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownQuant.Name = "nUpDownQuant";
            this.nUpDownQuant.Size = new System.Drawing.Size(120, 27);
            this.nUpDownQuant.TabIndex = 55;
            // 
            // lblQntEstoque
            // 
            this.lblQntEstoque.AutoSize = true;
            this.lblQntEstoque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntEstoque.Location = new System.Drawing.Point(36, 465);
            this.lblQntEstoque.Name = "lblQntEstoque";
            this.lblQntEstoque.Size = new System.Drawing.Size(94, 20);
            this.lblQntEstoque.TabIndex = 54;
            this.lblQntEstoque.Text = "Quantidade:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnEditar.Location = new System.Drawing.Point(39, 508);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 53);
            this.btnVoltar.TabIndex = 52;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(405, 100);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(47, 20);
            this.lblCapa.TabIndex = 51;
            this.lblCapa.Text = "Capa:";
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoPubli.Location = new System.Drawing.Point(35, 393);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(141, 20);
            this.lblAnoPubli.TabIndex = 50;
            this.lblAnoPubli.Text = "Ano de Publicação:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(35, 317);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 20);
            this.lblGenero.TabIndex = 49;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(35, 243);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 20);
            this.lblISBN.TabIndex = 48;
            this.lblISBN.Text = "ISBN:";
            // 
            // txbISBN
            // 
            this.txbISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbISBN.Location = new System.Drawing.Point(40, 267);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(287, 29);
            this.txbISBN.TabIndex = 47;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(35, 170);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 20);
            this.lblAutor.TabIndex = 46;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(40, 195);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(287, 29);
            this.txbAutor.TabIndex = 45;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 20);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Título:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(40, 125);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(287, 29);
            this.txbTitulo.TabIndex = 43;
            // 
            // pbxCapa
            // 
            this.pbxCapa.Location = new System.Drawing.Point(409, 134);
            this.pbxCapa.Name = "pbxCapa";
            this.pbxCapa.Size = new System.Drawing.Size(162, 237);
            this.pbxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCapa.TabIndex = 42;
            this.pbxCapa.TabStop = false;
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.Location = new System.Drawing.Point(208, 28);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(244, 37);
            this.lblCL.TabIndex = 41;
            this.lblCL.Text = "DADOS DO LIVRO";
            // 
            // DadosLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelDadosLivro);
            this.Name = "DadosLivro";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormVerDadosLivro_Load);
            this.panelDadosLivro.ResumeLayout(false);
            this.panelDadosLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDadosLivro;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.Button btnRealizaEmp;
        private System.Windows.Forms.TextBox txbSinopse;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.TextBox txbAnoPubli;
        private System.Windows.Forms.NumericUpDown nUpDownQuant;
        private System.Windows.Forms.Label lblQntEstoque;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.Label lblAnoPubli;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txbISBN;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.PictureBox pbxCapa;
        private System.Windows.Forms.Label lblCL;
    }
}