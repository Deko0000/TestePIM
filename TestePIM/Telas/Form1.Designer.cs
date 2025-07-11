﻿namespace TestePIM
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelDownSair = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.panelLivrosSubMenu = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnBuscaLivros = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.panelCadastrosSubMenu = new System.Windows.Forms.Panel();
            this.btnFunCadastrados = new System.Windows.Forms.Button();
            this.btnUsuCadastrados = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroLivros = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenuForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelDownSair.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelLivrosSubMenu.SuspendLayout();
            this.panelCadastrosSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenuForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDownSair
            // 
            this.panelDownSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelDownSair.Controls.Add(this.btnSair);
            this.panelDownSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDownSair.Location = new System.Drawing.Point(0, 619);
            this.panelDownSair.Name = "panelDownSair";
            this.panelDownSair.Size = new System.Drawing.Size(859, 37);
            this.panelDownSair.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 37);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "[←] Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.panelSideMenu.Controls.Add(this.btnRelatorios);
            this.panelSideMenu.Controls.Add(this.btnEmprestimos);
            this.panelSideMenu.Controls.Add(this.panelLivrosSubMenu);
            this.panelSideMenu.Controls.Add(this.btnLivros);
            this.panelSideMenu.Controls.Add(this.panelCadastrosSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCadastros);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(221, 619);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnRelatorios.Location = new System.Drawing.Point(0, 513);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(221, 40);
            this.btnRelatorios.TabIndex = 7;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprestimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmprestimos.FlatAppearance.BorderSize = 0;
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnEmprestimos.Location = new System.Drawing.Point(0, 473);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmprestimos.Size = new System.Drawing.Size(221, 40);
            this.btnEmprestimos.TabIndex = 5;
            this.btnEmprestimos.Text = "Esmpréstimos";
            this.btnEmprestimos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimos.UseVisualStyleBackColor = true;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            // 
            // panelLivrosSubMenu
            // 
            this.panelLivrosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.panelLivrosSubMenu.Controls.Add(this.btnEstoque);
            this.panelLivrosSubMenu.Controls.Add(this.btnBuscaLivros);
            this.panelLivrosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLivrosSubMenu.Location = new System.Drawing.Point(0, 387);
            this.panelLivrosSubMenu.Name = "panelLivrosSubMenu";
            this.panelLivrosSubMenu.Size = new System.Drawing.Size(221, 86);
            this.panelLivrosSubMenu.TabIndex = 4;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnEstoque.Location = new System.Drawing.Point(0, 40);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(221, 40);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnBuscaLivros
            // 
            this.btnBuscaLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscaLivros.FlatAppearance.BorderSize = 0;
            this.btnBuscaLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaLivros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBuscaLivros.Location = new System.Drawing.Point(0, 0);
            this.btnBuscaLivros.Name = "btnBuscaLivros";
            this.btnBuscaLivros.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnBuscaLivros.Size = new System.Drawing.Size(221, 40);
            this.btnBuscaLivros.TabIndex = 2;
            this.btnBuscaLivros.Text = "Buscar Livros";
            this.btnBuscaLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaLivros.UseVisualStyleBackColor = true;
            this.btnBuscaLivros.Click += new System.EventHandler(this.btnBuscaLivros_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnLivros.Location = new System.Drawing.Point(0, 347);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(221, 40);
            this.btnLivros.TabIndex = 3;
            this.btnLivros.Text = "Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // panelCadastrosSubMenu
            // 
            this.panelCadastrosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.panelCadastrosSubMenu.Controls.Add(this.btnFunCadastrados);
            this.panelCadastrosSubMenu.Controls.Add(this.btnUsuCadastrados);
            this.panelCadastrosSubMenu.Controls.Add(this.btnCadastroFuncionario);
            this.panelCadastrosSubMenu.Controls.Add(this.btnCadastroCliente);
            this.panelCadastrosSubMenu.Controls.Add(this.btnCadastroLivros);
            this.panelCadastrosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrosSubMenu.Location = new System.Drawing.Point(0, 139);
            this.panelCadastrosSubMenu.Name = "panelCadastrosSubMenu";
            this.panelCadastrosSubMenu.Size = new System.Drawing.Size(221, 208);
            this.panelCadastrosSubMenu.TabIndex = 2;
            // 
            // btnFunCadastrados
            // 
            this.btnFunCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunCadastrados.FlatAppearance.BorderSize = 0;
            this.btnFunCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunCadastrados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnFunCadastrados.Location = new System.Drawing.Point(0, 160);
            this.btnFunCadastrados.Name = "btnFunCadastrados";
            this.btnFunCadastrados.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnFunCadastrados.Size = new System.Drawing.Size(221, 40);
            this.btnFunCadastrados.TabIndex = 6;
            this.btnFunCadastrados.Text = "Funcionários Cadastrados";
            this.btnFunCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunCadastrados.UseVisualStyleBackColor = true;
            this.btnFunCadastrados.Click += new System.EventHandler(this.btnFunCadastrados_Click);
            // 
            // btnUsuCadastrados
            // 
            this.btnUsuCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuCadastrados.FlatAppearance.BorderSize = 0;
            this.btnUsuCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuCadastrados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnUsuCadastrados.Location = new System.Drawing.Point(0, 120);
            this.btnUsuCadastrados.Name = "btnUsuCadastrados";
            this.btnUsuCadastrados.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnUsuCadastrados.Size = new System.Drawing.Size(221, 40);
            this.btnUsuCadastrados.TabIndex = 5;
            this.btnUsuCadastrados.Text = "Clientes Cadastrados";
            this.btnUsuCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuCadastrados.UseVisualStyleBackColor = true;
            this.btnUsuCadastrados.Click += new System.EventHandler(this.btnUsuCadastrados_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(0, 80);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(221, 40);
            this.btnCadastroFuncionario.TabIndex = 4;
            this.btnCadastroFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 40);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnCadastroCliente.Size = new System.Drawing.Size(221, 40);
            this.btnCadastroCliente.TabIndex = 3;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroLivros
            // 
            this.btnCadastroLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroLivros.FlatAppearance.BorderSize = 0;
            this.btnCadastroLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLivros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCadastroLivros.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroLivros.Name = "btnCadastroLivros";
            this.btnCadastroLivros.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnCadastroLivros.Size = new System.Drawing.Size(221, 40);
            this.btnCadastroLivros.TabIndex = 2;
            this.btnCadastroLivros.Text = "Cadastro de Livros";
            this.btnCadastroLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroLivros.UseVisualStyleBackColor = true;
            this.btnCadastroLivros.Click += new System.EventHandler(this.btnCadastroLivros_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCadastros.Location = new System.Drawing.Point(0, 99);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(221, 40);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(221, 99);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenuForm
            // 
            this.panelMenuForm.Controls.Add(this.pictureBox2);
            this.panelMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuForm.Location = new System.Drawing.Point(221, 0);
            this.panelMenuForm.Name = "panelMenuForm";
            this.panelMenuForm.Size = new System.Drawing.Size(638, 619);
            this.panelMenuForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestePIM.Properties.Resources.knowledge__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 656);
            this.Controls.Add(this.panelMenuForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelDownSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelDownSair.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLivrosSubMenu.ResumeLayout(false);
            this.panelCadastrosSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelMenuForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDownSair;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenuForm;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Panel panelLivrosSubMenu;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnBuscaLivros;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Panel panelCadastrosSubMenu;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroLivros;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnFunCadastrados;
        private System.Windows.Forms.Button btnUsuCadastrados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

