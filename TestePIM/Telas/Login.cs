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
        // Variáveis para o login do administrador
        public string nomeAdmin = "admin";
        public string senhaAdmin = "1234";
        public Login()
        {
            // Inicializa os componentes do formulário
            InitializeComponent();
        }

        // Evento de carregamento do formulário
        private void Login_Load(object sender, EventArgs e)
        {
            txbSenha.PasswordChar = '*'; // Ocultar senha inicialmente
        }

        // Evendo de marcação do checkbox para mostrar/ocultar a senha
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

        // Guarda referência ao formulário ativo exibido dentro do painel
        private Form ativaForm = null;

        // Método para abrir dinamicamente um formulário dentro do painel "panelLoginForm"
        private void abreLoginForm(Form menuForm)
        {
            // Fecha o formulário anterior se houver um ativo
            if (ativaForm != null)
                ativaForm.Close();
            ativaForm = menuForm;
            // Configura o formulário para ser embutido dentro do painel
            menuForm.TopLevel = false; // Faz com que o formulário se comporte como controle
            menuForm.FormBorderStyle = FormBorderStyle.None; // Remove bordas do formulário
            menuForm.Dock = DockStyle.Fill; // Faz preencher todo o painel

            // Adiciona e exibe o formulário dentro do painel
            panelLoginForm.Controls.Add(menuForm);
            panelLoginForm.Tag = menuForm;
            menuForm.BringToFront(); // Garante que o formulário esteja na frente
            menuForm.Show();
        }

        // Evento de clique no link "Esqueci minha senha"
        private void lklEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de recuperação de senha no painel
            abreLoginForm(new EsqueciSenha());
        }

        // Evento de clique no botão "Logar"
        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txbNome.Text;
            string senha = txbSenha.Text;

            // Verifica se os dados correspondem ao login de administrador (hardcoded)
            if (usuario == nomeAdmin && senha == senhaAdmin)
            {
                // Loga como administrador
                VerificaAdm.Logar(new Funcionario("Administrador", "", "", DateTime.MinValue, "", ""), true);
                MessageBox.Show("Login bem-sucedido! Bem-vindo, administrador.");

                // Abre o menu principal e oculta a tela de login
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                return;
            }

            // Procura funcionário válido com base em nome e senha informados
            var funcionario = Listas.Funcionarios
                .FirstOrDefault(f => f.Nome == usuario && f.Senha == senha);

            if (funcionario != null)
            {
                // Loga como funcionário comum
                VerificaAdm.Logar(funcionario, false);
                MessageBox.Show("Login bem-sucedido! Bem-vindo, " + funcionario.Nome + ".");

                // Abre o menu principal e oculta a tela de login
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                // Nenhum funcionário ou administrador correspondente foi encontrado
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
    }
}

