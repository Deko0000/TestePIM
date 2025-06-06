namespace TestePIM.Telas
{
    partial class BuscaLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaLivros));
            this.panelBuscaLivro = new System.Windows.Forms.Panel();
            this.panelCardsLivros = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.pbLupa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.panelBuscaLivro.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscaLivro
            // 
            this.panelBuscaLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panelBuscaLivro.Controls.Add(this.panelCardsLivros);
            this.panelBuscaLivro.Controls.Add(this.panelHeader);
            this.panelBuscaLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscaLivro.Location = new System.Drawing.Point(0, 0);
            this.panelBuscaLivro.Name = "panelBuscaLivro";
            this.panelBuscaLivro.Size = new System.Drawing.Size(638, 619);
            this.panelBuscaLivro.TabIndex = 0;
            // 
            // panelCardsLivros
            // 
            this.panelCardsLivros.AutoScroll = true;
            this.panelCardsLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardsLivros.Location = new System.Drawing.Point(0, 234);
            this.panelCardsLivros.Name = "panelCardsLivros";
            this.panelCardsLivros.Size = new System.Drawing.Size(638, 385);
            this.panelCardsLivros.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.cbxGenero);
            this.panelHeader.Controls.Add(this.pbLupa);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Controls.Add(this.txbBuscar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 234);
            this.panelHeader.TabIndex = 0;
            // 
            // cbxGenero
            // 
            this.cbxGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.cbxGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(409, 147);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(183, 25);
            this.cbxGenero.TabIndex = 82;
            // 
            // pbLupa
            // 
            this.pbLupa.Image = ((System.Drawing.Image)(resources.GetObject("pbLupa.Image")));
            this.pbLupa.Location = new System.Drawing.Point(46, 141);
            this.pbLupa.Name = "pbLupa";
            this.pbLupa.Size = new System.Drawing.Size(32, 32);
            this.pbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLupa.TabIndex = 81;
            this.pbLupa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(193, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 80;
            this.label1.Text = "BUSCA DE LIVROS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // txbBuscar
            // 
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(86, 147);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(298, 26);
            this.txbBuscar.TabIndex = 78;
            // 
            // BuscaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelBuscaLivro);
            this.Name = "BuscaLivros";
            this.ShowIcon = false;
            this.panelBuscaLivro.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscaLivro;
        private System.Windows.Forms.Panel panelCardsLivros;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.PictureBox pbLupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbBuscar;
    }
}