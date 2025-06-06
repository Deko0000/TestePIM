namespace TestePIM.Telas
{
    partial class Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.panelEstoqueLivro = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVerDados = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbLupa = new System.Windows.Forms.PictureBox();
            this.lblLC = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.panelEstoqueLivro.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstoqueLivro
            // 
            this.panelEstoqueLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panelEstoqueLivro.Controls.Add(this.panelDataGrid);
            this.panelEstoqueLivro.Controls.Add(this.panelHeader);
            this.panelEstoqueLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstoqueLivro.Location = new System.Drawing.Point(0, 0);
            this.panelEstoqueLivro.Name = "panelEstoqueLivro";
            this.panelEstoqueLivro.Size = new System.Drawing.Size(638, 619);
            this.panelEstoqueLivro.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.AutoScroll = true;
            this.panelDataGrid.AutoSize = true;
            this.panelDataGrid.Controls.Add(this.btnExcluir);
            this.panelDataGrid.Controls.Add(this.btnVerDados);
            this.panelDataGrid.Controls.Add(this.btnEditar);
            this.panelDataGrid.Controls.Add(this.dgvLivros);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 220);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(638, 399);
            this.panelDataGrid.TabIndex = 76;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnExcluir.Location = new System.Drawing.Point(476, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 40);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVerDados
            // 
            this.btnVerDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnVerDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDados.FlatAppearance.BorderSize = 0;
            this.btnVerDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnVerDados.Location = new System.Drawing.Point(251, 19);
            this.btnVerDados.Name = "btnVerDados";
            this.btnVerDados.Size = new System.Drawing.Size(139, 40);
            this.btnVerDados.TabIndex = 53;
            this.btnVerDados.Text = "VER DADOS";
            this.btnVerDados.UseVisualStyleBackColor = false;
            this.btnVerDados.Click += new System.EventHandler(this.btnVerDados_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnEditar.Location = new System.Drawing.Point(22, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 40);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.Location = new System.Drawing.Point(22, 76);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(593, 321);
            this.dgvLivros.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.pbLupa);
            this.panelHeader.Controls.Add(this.lblLC);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Controls.Add(this.txbBuscar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 220);
            this.panelHeader.TabIndex = 75;
            // 
            // pbLupa
            // 
            this.pbLupa.Image = ((System.Drawing.Image)(resources.GetObject("pbLupa.Image")));
            this.pbLupa.Location = new System.Drawing.Point(139, 135);
            this.pbLupa.Name = "pbLupa";
            this.pbLupa.Size = new System.Drawing.Size(32, 32);
            this.pbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLupa.TabIndex = 70;
            this.pbLupa.TabStop = false;
            // 
            // lblLC
            // 
            this.lblLC.AutoSize = true;
            this.lblLC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblLC.Location = new System.Drawing.Point(160, 57);
            this.lblLC.Name = "lblLC";
            this.lblLC.Size = new System.Drawing.Size(316, 37);
            this.lblLC.TabIndex = 69;
            this.lblLC.Text = "LIVROS CADASTRADOS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(4, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(179, 141);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(298, 26);
            this.txbBuscar.TabIndex = 67;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelEstoqueLivro);
            this.Name = "Estoque";
            this.ShowIcon = false;
            this.panelEstoqueLivro.ResumeLayout(false);
            this.panelEstoqueLivro.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstoqueLivro;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVerDados;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbLupa;
        private System.Windows.Forms.Label lblLC;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbBuscar;
    }
}