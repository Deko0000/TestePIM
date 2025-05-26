namespace TestePIM.Telas.Emprestimo
{
    partial class AcompanhaEmp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcompanhaEmp));
            this.panelAcomEmp = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.btnBuscaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblRE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimparPeriodo = new System.Windows.Forms.Button();
            this.panelAcomEmp.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.panelBusca.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcomEmp
            // 
            this.panelAcomEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panelAcomEmp.Controls.Add(this.panelDataGrid);
            this.panelAcomEmp.Controls.Add(this.panelBusca);
            this.panelAcomEmp.Controls.Add(this.panelHeader);
            this.panelAcomEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcomEmp.Location = new System.Drawing.Point(0, 0);
            this.panelAcomEmp.Name = "panelAcomEmp";
            this.panelAcomEmp.Size = new System.Drawing.Size(638, 619);
            this.panelAcomEmp.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.btnVerDetalhes);
            this.panelDataGrid.Controls.Add(this.btnDevolver);
            this.panelDataGrid.Controls.Add(this.label3);
            this.panelDataGrid.Controls.Add(this.dgvEmprestimos);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 221);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(638, 398);
            this.panelDataGrid.TabIndex = 4;
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
            this.btnVerDetalhes.Click += new System.EventHandler(this.btnVerDetalhes_Click);
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
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "📋 Lista de Empréstimos: ";
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestimos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmprestimos.Location = new System.Drawing.Point(23, 39);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(593, 296);
            this.dgvEmprestimos.TabIndex = 1;
            // 
            // panelBusca
            // 
            this.panelBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusca.Controls.Add(this.btnLimparPeriodo);
            this.panelBusca.Controls.Add(this.btnBuscaPeriodo);
            this.panelBusca.Controls.Add(this.label2);
            this.panelBusca.Controls.Add(this.dtpFinal);
            this.panelBusca.Controls.Add(this.label1);
            this.panelBusca.Controls.Add(this.cbxStatus);
            this.panelBusca.Controls.Add(this.dtpInicio);
            this.panelBusca.Controls.Add(this.lblStatus);
            this.panelBusca.Controls.Add(this.lblBuscar);
            this.panelBusca.Controls.Add(this.txbBusca);
            this.panelBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusca.Location = new System.Drawing.Point(0, 106);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(638, 115);
            this.panelBusca.TabIndex = 3;
            // 
            // btnBuscaPeriodo
            // 
            this.btnBuscaPeriodo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscaPeriodo.FlatAppearance.BorderSize = 0;
            this.btnBuscaPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaPeriodo.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBuscaPeriodo.Location = new System.Drawing.Point(477, 57);
            this.btnBuscaPeriodo.Name = "btnBuscaPeriodo";
            this.btnBuscaPeriodo.Size = new System.Drawing.Size(36, 25);
            this.btnBuscaPeriodo.TabIndex = 8;
            this.btnBuscaPeriodo.Text = "🔍";
            this.btnBuscaPeriodo.UseVisualStyleBackColor = false;
            this.btnBuscaPeriodo.Click += new System.EventHandler(this.btnBuscaPeriodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 63);
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
            this.dtpFinal.Location = new System.Drawing.Point(300, 57);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(163, 25);
            this.dtpFinal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "📅 De:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(376, 15);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 25);
            this.cbxStatus.TabIndex = 2;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(61, 57);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(163, 25);
            this.dtpInicio.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(311, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "⏳ Status:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(63, 23);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "🔍 Buscar:";
            // 
            // txbBusca
            // 
            this.txbBusca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusca.Location = new System.Drawing.Point(137, 15);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(163, 25);
            this.txbBusca.TabIndex = 1;
            this.txbBusca.TextChanged += new System.EventHandler(this.txbBusca_TextChanged);
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
            this.panelHeader.TabIndex = 2;
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblRE.Location = new System.Drawing.Point(90, 31);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(472, 32);
            this.lblRE.TabIndex = 80;
            this.lblRE.Text = "ACOMPANHAMENTO DE EMPRÉSTIMOS";
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
            // btnLimparPeriodo
            // 
            this.btnLimparPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnLimparPeriodo.FlatAppearance.BorderSize = 0;
            this.btnLimparPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPeriodo.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnLimparPeriodo.Location = new System.Drawing.Point(520, 57);
            this.btnLimparPeriodo.Name = "btnLimparPeriodo";
            this.btnLimparPeriodo.Size = new System.Drawing.Size(90, 25);
            this.btnLimparPeriodo.TabIndex = 9;
            this.btnLimparPeriodo.Text = "LIMPAR";
            this.btnLimparPeriodo.UseVisualStyleBackColor = false;
            this.btnLimparPeriodo.Click += new System.EventHandler(this.btnLimparPeriodo_Click);
            // 
            // AcompanhaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelAcomEmp);
            this.Name = "AcompanhaEmp";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AcompanhaEmp_Load);
            this.panelAcomEmp.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcomEmp;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnBuscaPeriodo;
        private System.Windows.Forms.Button btnLimparPeriodo;
    }
}