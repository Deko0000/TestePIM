namespace TestePIM
{
    partial class CadastroLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivros));
            this.btnPegaImagem = new System.Windows.Forms.Button();
            this.lblCL = new System.Windows.Forms.Label();
            this.pbxCapa = new System.Windows.Forms.PictureBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txbISBN = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAnoPubli = new System.Windows.Forms.Label();
            this.lblCapa = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblQntEstoque = new System.Windows.Forms.Label();
            this.nUpDownQuant = new System.Windows.Forms.NumericUpDown();
            this.txbAnoPubli = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.txbSinopse = new System.Windows.Forms.TextBox();
            this.btnBuscarISBN = new System.Windows.Forms.Button();
            this.txbGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPegaImagem
            // 
            this.btnPegaImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnPegaImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPegaImagem.FlatAppearance.BorderSize = 0;
            this.btnPegaImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegaImagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegaImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnPegaImagem.Location = new System.Drawing.Point(497, 218);
            this.btnPegaImagem.Name = "btnPegaImagem";
            this.btnPegaImagem.Size = new System.Drawing.Size(119, 47);
            this.btnPegaImagem.TabIndex = 0;
            this.btnPegaImagem.Text = "BUSCAR IMAGEM";
            this.btnPegaImagem.UseVisualStyleBackColor = false;
            this.btnPegaImagem.Click += new System.EventHandler(this.btnPegaImagem_Click);
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.Location = new System.Drawing.Point(165, 18);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(303, 37);
            this.lblCL.TabIndex = 1;
            this.lblCL.Text = "CADASTRO DE LIVROS";
            // 
            // pbxCapa
            // 
            this.pbxCapa.Location = new System.Drawing.Point(329, 124);
            this.pbxCapa.Name = "pbxCapa";
            this.pbxCapa.Size = new System.Drawing.Size(162, 237);
            this.pbxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCapa.TabIndex = 2;
            this.pbxCapa.TabStop = false;
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(25, 115);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(287, 29);
            this.txbTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 90);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 20);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(20, 160);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 20);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(25, 185);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(287, 29);
            this.txbAutor.TabIndex = 6;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(20, 233);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 20);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN:";
            // 
            // txbISBN
            // 
            this.txbISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbISBN.Location = new System.Drawing.Point(25, 257);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(287, 29);
            this.txbISBN.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(20, 307);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 20);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoPubli.Location = new System.Drawing.Point(20, 383);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(141, 20);
            this.lblAnoPubli.TabIndex = 11;
            this.lblAnoPubli.Text = "Ano de Publicação:";
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(325, 90);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(47, 20);
            this.lblCapa.TabIndex = 13;
            this.lblCapa.Text = "Capa:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(-8, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 53);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnCadastrar.Location = new System.Drawing.Point(25, 557);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 40);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblQntEstoque
            // 
            this.lblQntEstoque.AutoSize = true;
            this.lblQntEstoque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntEstoque.Location = new System.Drawing.Point(21, 455);
            this.lblQntEstoque.Name = "lblQntEstoque";
            this.lblQntEstoque.Size = new System.Drawing.Size(94, 20);
            this.lblQntEstoque.TabIndex = 17;
            this.lblQntEstoque.Text = "Quantidade:";
            // 
            // nUpDownQuant
            // 
            this.nUpDownQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.nUpDownQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpDownQuant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownQuant.Location = new System.Drawing.Point(121, 452);
            this.nUpDownQuant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownQuant.Name = "nUpDownQuant";
            this.nUpDownQuant.Size = new System.Drawing.Size(120, 27);
            this.nUpDownQuant.TabIndex = 18;
            // 
            // txbAnoPubli
            // 
            this.txbAnoPubli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAnoPubli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnoPubli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnoPubli.Location = new System.Drawing.Point(24, 406);
            this.txbAnoPubli.Name = "txbAnoPubli";
            this.txbAnoPubli.Size = new System.Drawing.Size(217, 29);
            this.txbAnoPubli.TabIndex = 19;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnLimpar.Location = new System.Drawing.Point(189, 557);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 40);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(325, 378);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(67, 20);
            this.lblSinopse.TabIndex = 36;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // txbSinopse
            // 
            this.txbSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbSinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSinopse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSinopse.Location = new System.Drawing.Point(329, 401);
            this.txbSinopse.Multiline = true;
            this.txbSinopse.Name = "txbSinopse";
            this.txbSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSinopse.Size = new System.Drawing.Size(287, 150);
            this.txbSinopse.TabIndex = 37;
            // 
            // btnBuscarISBN
            // 
            this.btnBuscarISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscarISBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarISBN.FlatAppearance.BorderSize = 0;
            this.btnBuscarISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarISBN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnBuscarISBN.Location = new System.Drawing.Point(25, 499);
            this.btnBuscarISBN.Name = "btnBuscarISBN";
            this.btnBuscarISBN.Size = new System.Drawing.Size(149, 40);
            this.btnBuscarISBN.TabIndex = 38;
            this.btnBuscarISBN.Text = "BUSCAR ISBN";
            this.btnBuscarISBN.UseVisualStyleBackColor = false;
            this.btnBuscarISBN.Click += new System.EventHandler(this.btnBuscarISBN_Click);
            // 
            // txbGenero
            // 
            this.txbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenero.Location = new System.Drawing.Point(24, 332);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(217, 29);
            this.txbGenero.TabIndex = 39;
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.btnBuscarISBN);
            this.Controls.Add(this.txbSinopse);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbAnoPubli);
            this.Controls.Add(this.nUpDownQuant);
            this.Controls.Add(this.lblQntEstoque);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCapa);
            this.Controls.Add(this.lblAnoPubli);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txbISBN);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.pbxCapa);
            this.Controls.Add(this.lblCL);
            this.Controls.Add(this.btnPegaImagem);
            this.Name = "CadastroLivros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPegaImagem;
        private System.Windows.Forms.Label lblCL;
        private System.Windows.Forms.PictureBox pbxCapa;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txbISBN;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAnoPubli;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblQntEstoque;
        private System.Windows.Forms.NumericUpDown nUpDownQuant;
        private System.Windows.Forms.TextBox txbAnoPubli;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.TextBox txbSinopse;
        private System.Windows.Forms.Button btnBuscarISBN;
        private System.Windows.Forms.TextBox txbGenero;
    }
}