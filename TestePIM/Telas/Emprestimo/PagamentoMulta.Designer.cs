namespace TestePIM.Telas.Emprestimo
{
    partial class PagamentoMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagamentoMulta));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDaDevolu = new System.Windows.Forms.DateTimePicker();
            this.cbxBuscaMulta = new System.Windows.Forms.ComboBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataDevolu = new System.Windows.Forms.Label();
            this.dtpDevoluPrevista = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbDiasAtraso = new System.Windows.Forms.TextBox();
            this.lblDiasAT = new System.Windows.Forms.Label();
            this.txbValorMulta = new System.Windows.Forms.TextBox();
            this.lblValorMulta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbtnDinheiro = new System.Windows.Forms.RadioButton();
            this.rbtnPix = new System.Windows.Forms.RadioButton();
            this.rbtnCartao = new System.Windows.Forms.RadioButton();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Data da Devolução:";
            // 
            // dtpDaDevolu
            // 
            this.dtpDaDevolu.Enabled = false;
            this.dtpDaDevolu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDaDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDaDevolu.Location = new System.Drawing.Point(15, 427);
            this.dtpDaDevolu.Name = "dtpDaDevolu";
            this.dtpDaDevolu.Size = new System.Drawing.Size(200, 29);
            this.dtpDaDevolu.TabIndex = 125;
            // 
            // cbxBuscaMulta
            // 
            this.cbxBuscaMulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxBuscaMulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscaMulta.FormattingEnabled = true;
            this.cbxBuscaMulta.Location = new System.Drawing.Point(413, 145);
            this.cbxBuscaMulta.Name = "cbxBuscaMulta";
            this.cbxBuscaMulta.Size = new System.Drawing.Size(213, 29);
            this.cbxBuscaMulta.TabIndex = 123;
            this.cbxBuscaMulta.SelectedIndexChanged += new System.EventHandler(this.cbxBuscaMulta_SelectedIndexChanged);
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(408, 117);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(174, 25);
            this.lblMP.TabIndex = 122;
            this.lblMP.Text = "Multas Pendentes:";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(319, 169);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaCliente.TabIndex = 121;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(72, 117);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(182, 25);
            this.lblCliente.TabIndex = 114;
            this.lblCliente.Text = "BUSCA DE CLIENTE";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 20);
            this.lblNome.TabIndex = 116;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(16, 178);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(287, 29);
            this.txbNome.TabIndex = 115;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(11, 218);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 20);
            this.lblCPF.TabIndex = 120;
            this.lblCPF.Text = "CPF:";
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(16, 243);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.ReadOnly = true;
            this.txbCPF.Size = new System.Drawing.Size(287, 29);
            this.txbCPF.TabIndex = 119;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(455, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(430, 525);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(178, 36);
            this.btnConfirmar.TabIndex = 112;
            this.btnConfirmar.Text = "CONFIRMAR PAGAMENTO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(270, 307);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(118, 29);
            this.txbStatus.TabIndex = 107;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(266, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 111;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataDevolu
            // 
            this.lblDataDevolu.AutoSize = true;
            this.lblDataDevolu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolu.Location = new System.Drawing.Point(12, 344);
            this.lblDataDevolu.Name = "lblDataDevolu";
            this.lblDataDevolu.Size = new System.Drawing.Size(146, 20);
            this.lblDataDevolu.TabIndex = 110;
            this.lblDataDevolu.Text = "Devolução Prevista:";
            // 
            // dtpDevoluPrevista
            // 
            this.dtpDevoluPrevista.Enabled = false;
            this.dtpDevoluPrevista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevoluPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevoluPrevista.Location = new System.Drawing.Point(16, 367);
            this.dtpDevoluPrevista.Name = "dtpDevoluPrevista";
            this.dtpDevoluPrevista.Size = new System.Drawing.Size(200, 29);
            this.dtpDevoluPrevista.TabIndex = 109;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(12, 284);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(157, 20);
            this.lblDataEmp.TabIndex = 108;
            this.lblDataEmp.Text = "Data do Empréstimo:";
            // 
            // dtpEmp
            // 
            this.dtpEmp.Enabled = false;
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(16, 307);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(200, 29);
            this.dtpEmp.TabIndex = 106;
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
            this.panelHeader.TabIndex = 105;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblDE.Location = new System.Drawing.Point(172, 31);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(289, 32);
            this.lblDE.TabIndex = 80;
            this.lblDE.Text = "PAGAMENTO DE MULTA";
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
            // txbDiasAtraso
            // 
            this.txbDiasAtraso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbDiasAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiasAtraso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiasAtraso.Location = new System.Drawing.Point(270, 367);
            this.txbDiasAtraso.Name = "txbDiasAtraso";
            this.txbDiasAtraso.ReadOnly = true;
            this.txbDiasAtraso.Size = new System.Drawing.Size(118, 29);
            this.txbDiasAtraso.TabIndex = 129;
            // 
            // lblDiasAT
            // 
            this.lblDiasAT.AutoSize = true;
            this.lblDiasAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasAT.Location = new System.Drawing.Point(266, 344);
            this.lblDiasAT.Name = "lblDiasAT";
            this.lblDiasAT.Size = new System.Drawing.Size(115, 20);
            this.lblDiasAT.TabIndex = 130;
            this.lblDiasAT.Text = "Dias de Atraso:";
            // 
            // txbValorMulta
            // 
            this.txbValorMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbValorMulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorMulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorMulta.Location = new System.Drawing.Point(270, 427);
            this.txbValorMulta.Name = "txbValorMulta";
            this.txbValorMulta.ReadOnly = true;
            this.txbValorMulta.Size = new System.Drawing.Size(118, 29);
            this.txbValorMulta.TabIndex = 127;
            // 
            // lblValorMulta
            // 
            this.lblValorMulta.AutoSize = true;
            this.lblValorMulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMulta.Location = new System.Drawing.Point(266, 404);
            this.lblValorMulta.Name = "lblValorMulta";
            this.lblValorMulta.Size = new System.Drawing.Size(115, 20);
            this.lblValorMulta.TabIndex = 128;
            this.lblValorMulta.Text = "Valor da Multa:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 135);
            this.panel1.TabIndex = 131;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnDinheiro);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 135);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnPix);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(95, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 135);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnCartao);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(190, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 135);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // rbtnDinheiro
            // 
            this.rbtnDinheiro.AutoSize = true;
            this.rbtnDinheiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDinheiro.Location = new System.Drawing.Point(16, 13);
            this.rbtnDinheiro.Name = "rbtnDinheiro";
            this.rbtnDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rbtnDinheiro.TabIndex = 1;
            this.rbtnDinheiro.TabStop = true;
            this.rbtnDinheiro.Text = "Dinheiro";
            this.rbtnDinheiro.UseVisualStyleBackColor = true;
            this.rbtnDinheiro.CheckedChanged += new System.EventHandler(this.rbtnDinheiro_CheckedChanged);
            // 
            // rbtnPix
            // 
            this.rbtnPix.AutoSize = true;
            this.rbtnPix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPix.Location = new System.Drawing.Point(29, 13);
            this.rbtnPix.Name = "rbtnPix";
            this.rbtnPix.Size = new System.Drawing.Size(39, 17);
            this.rbtnPix.TabIndex = 2;
            this.rbtnPix.TabStop = true;
            this.rbtnPix.Text = "Pix";
            this.rbtnPix.UseVisualStyleBackColor = true;
            this.rbtnPix.CheckedChanged += new System.EventHandler(this.rbtnPix_CheckedChanged);
            // 
            // rbtnCartao
            // 
            this.rbtnCartao.AutoSize = true;
            this.rbtnCartao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCartao.Location = new System.Drawing.Point(23, 13);
            this.rbtnCartao.Name = "rbtnCartao";
            this.rbtnCartao.Size = new System.Drawing.Size(56, 17);
            this.rbtnCartao.TabIndex = 3;
            this.rbtnCartao.TabStop = true;
            this.rbtnCartao.Text = "Cartão";
            this.rbtnCartao.UseVisualStyleBackColor = true;
            this.rbtnCartao.CheckedChanged += new System.EventHandler(this.rbtnCartao_CheckedChanged);
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(413, 186);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 322);
            this.panelLivro.TabIndex = 151;
            // 
            // PagamentoMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelLivro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbDiasAtraso);
            this.Controls.Add(this.lblDiasAT);
            this.Controls.Add(this.txbValorMulta);
            this.Controls.Add(this.lblValorMulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDaDevolu);
            this.Controls.Add(this.cbxBuscaMulta);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataDevolu);
            this.Controls.Add(this.dtpDevoluPrevista);
            this.Controls.Add(this.lblDataEmp);
            this.Controls.Add(this.dtpEmp);
            this.Controls.Add(this.panelHeader);
            this.Name = "PagamentoMulta";
            this.ShowIcon = false;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDaDevolu;
        private System.Windows.Forms.ComboBox cbxBuscaMulta;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataDevolu;
        private System.Windows.Forms.DateTimePicker dtpDevoluPrevista;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbDiasAtraso;
        private System.Windows.Forms.Label lblDiasAT;
        private System.Windows.Forms.TextBox txbValorMulta;
        private System.Windows.Forms.Label lblValorMulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnCartao;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbtnPix;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtnDinheiro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLivro;
    }
}