using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM
{
    public partial class Login : Form
    {
        public string emailAdmin = "admin@admin.com";
        public string senhaAdmin = "1234";
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txbSenha.PasswordChar = '*'; // Ocultar senha inicialmente
        }
        private void cbxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {

            if (txbSenha.PasswordChar == '*')
            {
                txbSenha.PasswordChar = '\0'; // Mostra a senha                
            }
            else
            {
                txbSenha.PasswordChar = '*'; // Oculta a senha

            }
        }
        private Form ativaForm = null;
        private void abreLoginForm(Form menuForm)
        {
            if (ativaForm != null)
                ativaForm.Close();
            ativaForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.FormBorderStyle = FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            panelLoginForm.Controls.Add(menuForm);
            panelLoginForm.Tag = menuForm;
            menuForm.BringToFront();
            menuForm.Show();
        }

        private void lklEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abreLoginForm(new EsqueciSenha());
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txbEmail.Text;
            string senha = txbSenha.Text;

            // Verifica se é o Admin
            if (usuario == emailAdmin && senha == senhaAdmin)
            {
                VerificaAdm.Logar(usuario, true); 
                MessageBox.Show("Login bem-sucedido! Bem-vindo, administrador.");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                return;
            }

            // Verifica se é um Funcionário
            var funcionario = Listas.Funcionarios
            .FirstOrDefault(f => f.Email == usuario && f.Senha == senha);

            if (funcionario != null)
            {
                VerificaAdm.Logar(funcionario.Email, false);  
                MessageBox.Show("Login bem-sucedido! Bem-vindo, " + funcionario.Nome + ".");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }


    }
  }

