namespace TestePIM.Telas
{
    partial class DadosLivroEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosLivroEstoque));
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.txbSinopse = new System.Windows.Forms.TextBox();
            this.txbAnoPubli = new System.Windows.Forms.TextBox();
            this.nUpDownQuant = new System.Windows.Forms.NumericUpDown();
            this.lblQntEstoque = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGenero
            // 
            this.txbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenero.Location = new System.Drawing.Point(31, 347);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(217, 29);
            this.txbGenero.TabIndex = 78;
            // 
            // txbSinopse
            // 
            this.txbSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbSinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSinopse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSinopse.Location = new System.Drawing.Point(336, 416);
            this.txbSinopse.Multiline = true;
            this.txbSinopse.Name = "txbSinopse";
            this.txbSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSinopse.Size = new System.Drawing.Size(287, 150);
            this.txbSinopse.TabIndex = 77;
            // 
            // txbAnoPubli
            // 
            this.txbAnoPubli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAnoPubli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnoPubli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnoPubli.Location = new System.Drawing.Point(31, 421);
            this.txbAnoPubli.Name = "txbAnoPubli";
            this.txbAnoPubli.Size = new System.Drawing.Size(217, 29);
            this.txbAnoPubli.TabIndex = 76;
            // 
            // nUpDownQuant
            // 
            this.nUpDownQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.nUpDownQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpDownQuant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownQuant.Location = new System.Drawing.Point(128, 467);
            this.nUpDownQuant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownQuant.Name = "nUpDownQuant";
            this.nUpDownQuant.Size = new System.Drawing.Size(120, 27);
            this.nUpDownQuant.TabIndex = 75;
            // 
            // lblQntEstoque
            // 
            this.lblQntEstoque.AutoSize = true;
            this.lblQntEstoque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntEstoque.Location = new System.Drawing.Point(28, 470);
            this.lblQntEstoque.Name = "lblQntEstoque";
            this.lblQntEstoque.Size = new System.Drawing.Size(94, 20);
            this.lblQntEstoque.TabIndex = 74;
            this.lblQntEstoque.Text = "Quantidade:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(-5, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 53);
            this.btnVoltar.TabIndex = 73;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(397, 105);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(47, 20);
            this.lblCapa.TabIndex = 72;
            this.lblCapa.Text = "Capa:";
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoPubli.Location = new System.Drawing.Point(27, 398);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(141, 20);
            this.lblAnoPubli.TabIndex = 71;
            this.lblAnoPubli.Text = "Ano de Publicação:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(27, 322);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 20);
            this.lblGenero.TabIndex = 70;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(27, 248);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 20);
            this.lblISBN.TabIndex = 69;
            this.lblISBN.Text = "ISBN:";
            // 
            // txbISBN
            // 
            this.txbISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbISBN.Location = new System.Drawing.Point(32, 272);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(287, 29);
            this.txbISBN.TabIndex = 68;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(27, 175);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 20);
            this.lblAutor.TabIndex = 67;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(32, 200);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(287, 29);
            this.txbAutor.TabIndex = 66;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 105);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 20);
            this.lblTitulo.TabIndex = 65;
            this.lblTitulo.Text = "Título:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(32, 130);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(287, 29);
            this.txbTitulo.TabIndex = 64;
            // 
            // pbxCapa
            // 
            this.pbxCapa.Location = new System.Drawing.Point(401, 139);
            this.pbxCapa.Name = "pbxCapa";
            this.pbxCapa.Size = new System.Drawing.Size(162, 237);
            this.pbxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCapa.TabIndex = 63;
            this.pbxCapa.TabStop = false;
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.Location = new System.Drawing.Point(191, 35);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(244, 37);
            this.lblCL.TabIndex = 62;
            this.lblCL.Text = "DADOS DO LIVRO";
            // 
            // DadosLivroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.txbSinopse);
            this.Controls.Add(this.txbAnoPubli);
            this.Controls.Add(this.nUpDownQuant);
            this.Controls.Add(this.lblQntEstoque);
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
            this.Name = "DadosLivroEstoque";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormVerDadosLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.TextBox txbSinopse;
        private System.Windows.Forms.TextBox txbAnoPubli;
        private System.Windows.Forms.NumericUpDown nUpDownQuant;
        private System.Windows.Forms.Label lblQntEstoque;
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