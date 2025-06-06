namespace TestePIM.Telas.Emprestimo
{
    partial class RealizaEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizaEmp));
            this.panelRealizaEmp = new System.Windows.Forms.Panel();
            this.panelBaixo = new System.Windows.Forms.Panel();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.lblCapa = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaLivro = new System.Windows.Forms.Button();
            this.lblLivro = new System.Windows.Forms.Label();
            this.txbLivro = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblRE = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelRealizaEmp.SuspendLayout();
            this.panelBaixo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRealizaEmp
            // 
            this.panelRealizaEmp.Controls.Add(this.panelBaixo);
            this.panelRealizaEmp.Controls.Add(this.panelHeader);
            this.panelRealizaEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRealizaEmp.Location = new System.Drawing.Point(0, 0);
            this.panelRealizaEmp.Name = "panelRealizaEmp";
            this.panelRealizaEmp.Size = new System.Drawing.Size(638, 619);
            this.panelRealizaEmp.TabIndex = 0;
            // 
            // panelBaixo
            // 
            this.panelBaixo.Controls.Add(this.panelLivro);
            this.panelBaixo.Controls.Add(this.btnCancelar);
            this.panelBaixo.Controls.Add(this.btnConfirmar);
            this.panelBaixo.Controls.Add(this.label1);
            this.panelBaixo.Controls.Add(this.dtpDevolucao);
            this.panelBaixo.Controls.Add(this.lblDataEmp);
            this.panelBaixo.Controls.Add(this.lblCapa);
            this.panelBaixo.Controls.Add(this.btnBuscaCliente);
            this.panelBaixo.Controls.Add(this.lblRA);
            this.panelBaixo.Controls.Add(this.txbRA);
            this.panelBaixo.Controls.Add(this.lblCliente);
            this.panelBaixo.Controls.Add(this.txbCliente);
            this.panelBaixo.Controls.Add(this.lblAutor);
            this.panelBaixo.Controls.Add(this.txbAutor);
            this.panelBaixo.Controls.Add(this.dtpEmprestimo);
            this.panelBaixo.Controls.Add(this.btnBuscaLivro);
            this.panelBaixo.Controls.Add(this.lblLivro);
            this.panelBaixo.Controls.Add(this.txbLivro);
            this.panelBaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaixo.Location = new System.Drawing.Point(0, 181);
            this.panelBaixo.Name = "panelBaixo";
            this.panelBaixo.Size = new System.Drawing.Size(638, 438);
            this.panelBaixo.TabIndex = 109;
            // 
            // panelLivro
            // 
            this.panelLivro.Location = new System.Drawing.Point(413, 46);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(213, 284);
            this.panelLivro.TabIndex = 149;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnCancelar.Location = new System.Drawing.Point(240, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 38);
            this.btnCancelar.TabIndex = 147;
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
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(15, 378);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(165, 38);
            this.btnConfirmar.TabIndex = 146;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 145;
            this.label1.Text = "Data de Devolução:";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpDevolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDevolucao.Enabled = false;
            this.dtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(224, 308);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDevolucao.Size = new System.Drawing.Size(165, 33);
            this.dtpDevolucao.TabIndex = 144;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(11, 284);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(169, 21);
            this.lblDataEmp.TabIndex = 143;
            this.lblDataEmp.Text = "Data de Empréstimo:";
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(409, 22);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(52, 21);
            this.lblCapa.TabIndex = 141;
            this.lblCapa.Text = "Capa:";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(359, 157);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaCliente.TabIndex = 140;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(11, 202);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(35, 21);
            this.lblRA.TabIndex = 139;
            this.lblRA.Text = "RA:";
            // 
            // txbRA
            // 
            this.txbRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRA.Location = new System.Drawing.Point(15, 226);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(335, 29);
            this.txbRA.TabIndex = 138;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(11, 142);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 21);
            this.lblCliente.TabIndex = 137;
            this.lblCliente.Text = "Cliente:";
            // 
            // txbCliente
            // 
            this.txbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(15, 166);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(335, 29);
            this.txbCliente.TabIndex = 136;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(11, 82);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(58, 21);
            this.lblAutor.TabIndex = 135;
            this.lblAutor.Text = "Autor:";
            // 
            // txbAutor
            // 
            this.txbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(15, 106);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(335, 29);
            this.txbAutor.TabIndex = 134;
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEmprestimo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmprestimo.Location = new System.Drawing.Point(15, 308);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpEmprestimo.Size = new System.Drawing.Size(165, 33);
            this.dtpEmprestimo.TabIndex = 133;
            // 
            // btnBuscaLivro
            // 
            this.btnBuscaLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBuscaLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaLivro.FlatAppearance.BorderSize = 0;
            this.btnBuscaLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaLivro.Image")));
            this.btnBuscaLivro.Location = new System.Drawing.Point(359, 37);
            this.btnBuscaLivro.Name = "btnBuscaLivro";
            this.btnBuscaLivro.Size = new System.Drawing.Size(44, 38);
            this.btnBuscaLivro.TabIndex = 132;
            this.btnBuscaLivro.UseVisualStyleBackColor = false;
            this.btnBuscaLivro.Click += new System.EventHandler(this.btnBuscaLivro_Click);
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(11, 22);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(52, 21);
            this.lblLivro.TabIndex = 131;
            this.lblLivro.Text = "Livro:";
            // 
            // txbLivro
            // 
            this.txbLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLivro.Location = new System.Drawing.Point(15, 46);
            this.txbLivro.Name = "txbLivro";
            this.txbLivro.Size = new System.Drawing.Size(335, 29);
            this.txbLivro.TabIndex = 130;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.lblRE);
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(638, 181);
            this.panelHeader.TabIndex = 108;
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblRE.Location = new System.Drawing.Point(149, 74);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(326, 37);
            this.lblRE.TabIndex = 80;
            this.lblRE.Text = "REALIZAR EMPRÉSTIMO";
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
            // RealizaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(638, 619);
            this.Controls.Add(this.panelRealizaEmp);
            this.Name = "RealizaEmp";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.RealizaEmp_Load);
            this.panelRealizaEmp.ResumeLayout(false);
            this.panelBaixo.ResumeLayout(false);
            this.panelBaixo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRealizaEmp;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelBaixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.Button btnBuscaLivro;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox txbLivro;
        private System.Windows.Forms.Panel panelLivro;
    }
}