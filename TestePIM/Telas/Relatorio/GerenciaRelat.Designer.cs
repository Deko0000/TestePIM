namespace TestePIM.Telas.Relatorio
{
    partial class GerenciaRelat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaRelat));
            this.panelRelat = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRelat = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblRE = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscaPeriodo = new System.Windows.Forms.Button();
            this.btnLimparPeriodo = new System.Windows.Forms.Button();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelRelat.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRelat
            // 
            this.panelRelat.Controls.Add(this.panelDataGrid);
            this.panelRelat.Controls.Add(this.panelBusca);
            this.panelRelat.Controls.Add(this.panelHeader);
            this.panelRelat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRelat.Location = new System.Drawing.Point(0, 0);
            this.panelRelat.Name = "panelRelat";
            this.panelRelat.Size = new System.Drawing.Size(638, 619);
            this.panelRelat.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.btnExcluir);
            this.panelDataGrid.Controls.Add(this.label3);
            this.panelDataGrid.Controls.Add(this.dgvRelat);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 221);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(638, 398);
            this.panelDataGrid.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btnExcluir.Location = new System.Drawing.Point(508, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 25);
            this.btnExcluir.TabIndex = 81;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "📋 Lista de Relatórios: ";
            // 
            // dgvRelat
            // 
            this.dgvRelat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvRelat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelat.Location = new System.Drawing.Point(23, 65);
            this.dgvRelat.MultiSelect = false;
            this.dgvRelat.Name = "dgvRelat";
            this.dgvRelat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRelat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelat.Size = new System.Drawing.Size(593, 296);
            this.dgvRelat.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblRE);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 106);
            this.panelHeader.TabIndex = 5;
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblRE.Location = new System.Drawing.Point(170, 32);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(317, 32);
            this.lblRE.TabIndex = 80;
            this.lblRE.Text = "LISTAGEM DE RELATÓRIOS";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Location = new System.Drawing.Point(136, 47);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(283, 25);
            this.txbFiltro.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(62, 51);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "🔍 Buscar:";
            // 
            // btnBuscaPeriodo
            // 
            this.btnBuscaPeriodo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscaPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaPeriodo.FlatAppearance.BorderSize = 0;
            this.btnBuscaPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaPeriodo.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBuscaPeriodo.Location = new System.Drawing.Point(444, 47);
            this.btnBuscaPeriodo.Name = "btnBuscaPeriodo";
            this.btnBuscaPeriodo.Size = new System.Drawing.Size(36, 25);
            this.btnBuscaPeriodo.TabIndex = 8;
            this.btnBuscaPeriodo.Text = "🔍";
            this.btnBuscaPeriodo.UseVisualStyleBackColor = false;
            this.btnBuscaPeriodo.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimparPeriodo
            // 
            this.btnLimparPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnLimparPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparPeriodo.FlatAppearance.BorderSize = 0;
            this.btnLimparPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPeriodo.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnLimparPeriodo.Location = new System.Drawing.Point(487, 47);
            this.btnLimparPeriodo.Name = "btnLimparPeriodo";
            this.btnLimparPeriodo.Size = new System.Drawing.Size(90, 25);
            this.btnLimparPeriodo.TabIndex = 9;
            this.btnLimparPeriodo.Text = "LIMPAR";
            this.btnLimparPeriodo.UseVisualStyleBackColor = false;
            // 
            // panelBusca
            // 
            this.panelBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusca.Controls.Add(this.btnLimparPeriodo);
            this.panelBusca.Controls.Add(this.btnBuscaPeriodo);
            this.panelBusca.Controls.Add(this.lblBuscar);
            this.panelBusca.Controls.Add(this.txbFiltro);
            this.panelBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusca.Location = new System.Drawing.Point(0, 106);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(638, 115);
            this.panelBusca.TabIndex = 6;
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
            // GerenciaRelat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelRelat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciaRelat";
            this.panelRelat.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRelat;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRelat;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Button btnLimparPeriodo;
        private System.Windows.Forms.Button btnBuscaPeriodo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}