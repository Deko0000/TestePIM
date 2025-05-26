namespace TestePIM.Telas.Emprestimo
{
    partial class DevoluEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevoluEmp));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataDevolu = new System.Windows.Forms.Label();
            this.dtpDevolu = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBuscaLivro = new System.Windows.Forms.ComboBox();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.panelHeader.TabIndex = 4;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(138, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(359, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "DEVOLUÇÃO DE EMPRÉSTIMO";
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
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(247, 356);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(118, 29);
            this.txbStatus.TabIndex = 85;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(243, 333);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 89;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataDevolu
            // 
            this.lblDataDevolu.AutoSize = true;
            this.lblDataDevolu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolu.Location = new System.Drawing.Point(24, 393);
            this.lblDataDevolu.Name = "lblDataDevolu";
            this.lblDataDevolu.Size = new System.Drawing.Size(146, 20);
            this.lblDataDevolu.TabIndex = 88;
            this.lblDataDevolu.Text = "Devolução Prevista:";
            // 
            // dtpDevolu
            // 
            this.dtpDevolu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolu.Location = new System.Drawing.Point(28, 416);
            this.dtpDevolu.Name = "dtpDevolu";
            this.dtpDevolu.Size = new System.Drawing.Size(200, 29);
            this.dtpDevolu.TabIndex = 87;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(24, 333);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(157, 20);
            this.lblDataEmp.TabIndex = 86;
            this.lblDataEmp.Text = "Data do Empréstimo:";
            // 
            // dtpEmp
            // 
            this.dtpEmp.Enabled = false;
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(28, 356);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(200, 29);
            this.dtpEmp.TabIndex = 84;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(27, 530);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(178, 36);
            this.btnConfirmar.TabIndex = 90;
            this.btnConfirmar.Text = "CONFIRMAR DEVOLUÇÃO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(247, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 36);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(321, 177);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaCliente.TabIndex = 99;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(84, 125);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(182, 25);
            this.lblCliente.TabIndex = 92;
            this.lblCliente.Text = "BUSCA DE CLIENTE";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 161);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 20);
            this.lblNome.TabIndex = 94;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(28, 186);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(287, 29);
            this.txbNome.TabIndex = 93;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(23, 274);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(34, 20);
            this.lblRA.TabIndex = 98;
            this.lblRA.Text = "RA:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(28, 243);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(287, 29);
            this.txbEmail.TabIndex = 95;
            // 
            // txbRA
            // 
            this.txbRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRA.Location = new System.Drawing.Point(28, 299);
            this.txbRA.Name = "txbRA";
            this.txbRA.ReadOnly = true;
            this.txbRA.Size = new System.Drawing.Size(287, 29);
            this.txbRA.TabIndex = 97;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 96;
            this.lblEmail.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 100;
            this.label1.Text = "Livros Emprestados:";
            // 
            // cbxBuscaLivro
            // 
            this.cbxBuscaLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscaLivro.FormattingEnabled = true;
            this.cbxBuscaLivro.Location = new System.Drawing.Point(393, 185);
            this.cbxBuscaLivro.Name = "cbxBuscaLivro";
            this.cbxBuscaLivro.Size = new System.Drawing.Size(213, 29);
            this.cbxBuscaLivro.TabIndex = 101;
            this.cbxBuscaLivro.Click += new System.EventHandler(this.cbxBuscaLivro_SelectedIndexChanged);
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(393, 221);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 224);
            this.panelLivro.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Data da Devolução:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 476);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 103;
            // 
            // DevoluEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelLivro);
            this.Controls.Add(this.cbxBuscaLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataDevolu);
            this.Controls.Add(this.dtpDevolu);
            this.Controls.Add(this.lblDataEmp);
            this.Controls.Add(this.dtpEmp);
            this.Controls.Add(this.panelHeader);
            this.Name = "DevoluEmp";
            this.ShowIcon = false;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataDevolu;
        private System.Windows.Forms.DateTimePicker dtpDevolu;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBuscaLivro;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}