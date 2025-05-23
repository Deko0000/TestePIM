namespace TestePIM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblCadas = new System.Windows.Forms.Label();
            this.lblATL = new System.Windows.Forms.Label();
            this.lblEvo = new System.Windows.Forms.Label();
            this.lblGer = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblLA = new System.Windows.Forms.Label();
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.cbxMostraSenha = new System.Windows.Forms.CheckBox();
            this.lklEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBV = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.lblCadas);
            this.panel1.Controls.Add(this.lblATL);
            this.panel1.Controls.Add(this.lblEvo);
            this.panel1.Controls.Add(this.lblGer);
            this.panel1.Controls.Add(this.lblOrg);
            this.panel1.Controls.Add(this.lblLA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 539);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.Location = new System.Drawing.Point(96, 430);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(71, 64);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // lblCadas
            // 
            this.lblCadas.AutoSize = true;
            this.lblCadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblCadas.Location = new System.Drawing.Point(85, 394);
            this.lblCadas.Name = "lblCadas";
            this.lblCadas.Size = new System.Drawing.Size(103, 21);
            this.lblCadas.TabIndex = 11;
            this.lblCadas.Text = "Cadastre-se!";
            // 
            // lblATL
            // 
            this.lblATL.AutoSize = true;
            this.lblATL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblATL.Location = new System.Drawing.Point(34, 360);
            this.lblATL.Name = "lblATL";
            this.lblATL.Size = new System.Drawing.Size(205, 21);
            this.lblATL.TabIndex = 10;
            this.lblATL.Text = "Ainda não tem um Login?";
            // 
            // lblEvo
            // 
            this.lblEvo.AutoSize = true;
            this.lblEvo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblEvo.Location = new System.Drawing.Point(32, 266);
            this.lblEvo.Name = "lblEvo";
            this.lblEvo.Size = new System.Drawing.Size(78, 30);
            this.lblEvo.TabIndex = 9;
            this.lblEvo.Text = "Evolua";
            // 
            // lblGer
            // 
            this.lblGer.AutoSize = true;
            this.lblGer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblGer.Location = new System.Drawing.Point(141, 228);
            this.lblGer.Name = "lblGer";
            this.lblGer.Size = new System.Drawing.Size(98, 30);
            this.lblGer.TabIndex = 8;
            this.lblGer.Text = "Gerencie";
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblOrg.Location = new System.Drawing.Point(32, 191);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(101, 30);
            this.lblOrg.TabIndex = 7;
            this.lblOrg.Text = "Organize";
            // 
            // lblLA
            // 
            this.lblLA.AutoSize = true;
            this.lblLA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblLA.Location = new System.Drawing.Point(30, 141);
            this.lblLA.Name = "lblLA";
            this.lblLA.Size = new System.Drawing.Size(209, 37);
            this.lblLA.TabIndex = 6;
            this.lblLA.Text = "LIVRARIA ÁGIL";
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panelLoginForm.Controls.Add(this.cbxMostraSenha);
            this.panelLoginForm.Controls.Add(this.lklEsqueciSenha);
            this.panelLoginForm.Controls.Add(this.lblSenha);
            this.panelLoginForm.Controls.Add(this.txbSenha);
            this.panelLoginForm.Controls.Add(this.lblNome);
            this.panelLoginForm.Controls.Add(this.lblBV);
            this.panelLoginForm.Controls.Add(this.btnLogar);
            this.panelLoginForm.Controls.Add(this.txbNome);
            this.panelLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginForm.Location = new System.Drawing.Point(267, 0);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Size = new System.Drawing.Size(327, 539);
            this.panelLoginForm.TabIndex = 1;
            // 
            // cbxMostraSenha
            // 
            this.cbxMostraSenha.AutoSize = true;
            this.cbxMostraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.cbxMostraSenha.Location = new System.Drawing.Point(302, 293);
            this.cbxMostraSenha.Name = "cbxMostraSenha";
            this.cbxMostraSenha.Size = new System.Drawing.Size(15, 14);
            this.cbxMostraSenha.TabIndex = 6;
            this.cbxMostraSenha.UseVisualStyleBackColor = false;
            this.cbxMostraSenha.CheckedChanged += new System.EventHandler(this.cbxMostraSenha_CheckedChanged);
            // 
            // lklEsqueciSenha
            // 
            this.lklEsqueciSenha.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.lklEsqueciSenha.AutoSize = true;
            this.lklEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklEsqueciSenha.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklEsqueciSenha.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lklEsqueciSenha.Location = new System.Drawing.Point(83, 505);
            this.lklEsqueciSenha.Name = "lklEsqueciSenha";
            this.lklEsqueciSenha.Size = new System.Drawing.Size(172, 21);
            this.lklEsqueciSenha.TabIndex = 5;
            this.lklEsqueciSenha.TabStop = true;
            this.lklEsqueciSenha.Text = "Esqueci minha senha";
            this.lklEsqueciSenha.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.lklEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEsqueciSenha_LinkClicked);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(28, 258);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 21);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(32, 282);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(263, 33);
            this.txbSenha.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(28, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblBV
            // 
            this.lblBV.AutoSize = true;
            this.lblBV.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV.Location = new System.Drawing.Point(84, 44);
            this.lblBV.Name = "lblBV";
            this.lblBV.Size = new System.Drawing.Size(170, 32);
            this.lblBV.TabIndex = 1;
            this.lblBV.Text = "Bem Vindo(a)";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnLogar.Location = new System.Drawing.Point(32, 352);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(263, 36);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(32, 167);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(263, 33);
            this.txbNome.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 539);
            this.Controls.Add(this.panelLoginForm);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLoginForm.ResumeLayout(false);
            this.panelLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblBV;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel lklEsqueciSenha;
        private System.Windows.Forms.Label lblLA;
        private System.Windows.Forms.Label lblCadas;
        private System.Windows.Forms.Label lblATL;
        private System.Windows.Forms.Label lblEvo;
        private System.Windows.Forms.Label lblGer;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.CheckBox cbxMostraSenha;
    }
}