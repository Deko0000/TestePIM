namespace TestePIM.Telas.Emprestimo
{
    partial class Multas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multas));
            this.panelListaMulta = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblLM = new System.Windows.Forms.Label();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.btnBuscaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblVM = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelListaMulta.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.panelBusca.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListaMulta
            // 
            this.panelListaMulta.Controls.Add(this.panelDataGrid);
            this.panelListaMulta.Controls.Add(this.panelBusca);
            this.panelListaMulta.Controls.Add(this.panelHeader);
            this.panelListaMulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListaMulta.Location = new System.Drawing.Point(0, 0);
            this.panelListaMulta.Name = "panelListaMulta";
            this.panelListaMulta.Size = new System.Drawing.Size(638, 619);
            this.panelListaMulta.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.btnVerDetalhes);
            this.panelDataGrid.Controls.Add(this.btnDevolver);
            this.panelDataGrid.Controls.Add(this.lblLM);
            this.panelDataGrid.Controls.Add(this.dgvMultas);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 221);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(638, 398);
            this.panelDataGrid.TabIndex = 10;
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnVerDetalhes.FlatAppearance.BorderSize = 0;
            this.btnVerDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalhes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnVerDetalhes.Location = new System.Drawing.Point(161, 352);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(109, 25);
            this.btnVerDetalhes.TabIndex = 7;
            this.btnVerDetalhes.Text = "VER DETALHES";
            this.btnVerDetalhes.UseVisualStyleBackColor = false;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnDevolver.Location = new System.Drawing.Point(23, 352);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(109, 25);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "DEVOLVER";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // lblLM
            // 
            this.lblLM.AutoSize = true;
            this.lblLM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLM.Location = new System.Drawing.Point(22, 11);
            this.lblLM.Name = "lblLM";
            this.lblLM.Size = new System.Drawing.Size(122, 17);
            this.lblLM.TabIndex = 6;
            this.lblLM.Text = "📋 Lista de Multas: ";
            // 
            // dgvMultas
            // 
            this.dgvMultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMultas.Location = new System.Drawing.Point(23, 39);
            this.dgvMultas.MultiSelect = false;
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultas.Size = new System.Drawing.Size(593, 296);
            this.dgvMultas.TabIndex = 1;
            // 
            // panelBusca
            // 
            this.panelBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusca.Controls.Add(this.lblStatus);
            this.panelBusca.Controls.Add(this.cbxStatus);
            this.panelBusca.Controls.Add(this.btnBuscaPeriodo);
            this.panelBusca.Controls.Add(this.label2);
            this.panelBusca.Controls.Add(this.dtpFinal);
            this.panelBusca.Controls.Add(this.label1);
            this.panelBusca.Controls.Add(this.txbBusca);
            this.panelBusca.Controls.Add(this.lblBuscar);
            this.panelBusca.Controls.Add(this.dtpInicio);
            this.panelBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusca.Location = new System.Drawing.Point(0, 106);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(638, 115);
            this.panelBusca.TabIndex = 9;
            // 
            // btnBuscaPeriodo
            // 
            this.btnBuscaPeriodo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscaPeriodo.FlatAppearance.BorderSize = 0;
            this.btnBuscaPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaPeriodo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBuscaPeriodo.Location = new System.Drawing.Point(438, 57);
            this.btnBuscaPeriodo.Name = "btnBuscaPeriodo";
            this.btnBuscaPeriodo.Size = new System.Drawing.Size(85, 25);
            this.btnBuscaPeriodo.TabIndex = 8;
            this.btnBuscaPeriodo.Text = "🔍 BUSCAR";
            this.btnBuscaPeriodo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "📅 Até:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(284, 14);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(163, 25);
            this.dtpFinal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "📅 De:";
            // 
            // txbBusca
            // 
            this.txbBusca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusca.Location = new System.Drawing.Point(121, 58);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(296, 25);
            this.txbBusca.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(47, 61);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "🔍 Buscar:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(121, 14);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(163, 25);
            this.dtpInicio.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblVM);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 106);
            this.panelHeader.TabIndex = 8;
            // 
            // lblVM
            // 
            this.lblVM.AutoSize = true;
            this.lblVM.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblVM.Location = new System.Drawing.Point(163, 31);
            this.lblVM.Name = "lblVM";
            this.lblVM.Size = new System.Drawing.Size(306, 32);
            this.lblVM.TabIndex = 80;
            this.lblVM.Text = "VERIFICAÇÃO DE MULTAS";
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
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(522, 18);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(103, 21);
            this.cbxStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(457, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "⏳ Status:";
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelListaMulta);
            this.Name = "Multas";
            this.ShowIcon = false;
            this.panelListaMulta.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListaMulta;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lblLM;
        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Button btnBuscaPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblVM;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}