using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Telas;
using TestePIM.Telas.Relatorio;
using TestePIM.Telas.Emprestimo;

namespace TestePIM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();           
            btnCadastroFuncionario.Visible = false;
            btnFunCadastrados.Visible = false;

            // Define tamanho inicial do submenu de cadastros (modo padrão, não-admin)
            panelCadastrosSubMenu.Size = new Size(204, 128);
        }

        // Oculta os submenus ao carregar o formulário
       

        // Oculta ambos os submenus, útil antes de abrir outro
        private void escondeSubMenu()
        {
            if (panelCadastrosSubMenu.Visible == true)
                panelCadastrosSubMenu.Visible = false;
            if (panelLivrosSubMenu.Visible == true)
                panelLivrosSubMenu.Visible = false;
        }

        // Exibe submenu específico. Se já estiver visível, oculta.
        private void mostraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escondeSubMenu(); // Oculta todos os outros antes
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false; // Oculta se clicar novamente
            }
        }

        // Evento disparado quando o Menu é carregado
        public void Menu_Load(object sender, EventArgs e)
        {
            // Exibe botões extras apenas se o usuário logado for administrador
            if (VerificaAdm.IsAdmin)
            {
                panelCadastrosSubMenu.Size = new Size(204, 208); // Aumenta o painel para incluir novos botões
                btnCadastroFuncionario.Visible = true;
                btnFunCadastrados.Visible = true;
            }
        }

        #region Cadastros

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelCadastrosSubMenu);

        }

        private void btnCadastroLivros_Click(object sender, EventArgs e)
        {
            abreMenuForm(new CadastroLivros());
            escondeSubMenu();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            abreMenuForm(new CadastroClientes());
            escondeSubMenu();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            abreMenuForm(new CadastroFuncionario());
            escondeSubMenu();
        }

        private void btnUsuCadastrados_Click(object sender, EventArgs e)
        {
            abreMenuForm(new ClientesCadastrados());
            escondeSubMenu();
        }

        private void btnFunCadastrados_Click(object sender, EventArgs e)
        {
            abreMenuForm(new FuncionariosCadastrados());
            escondeSubMenu();
        }

        #endregion

        #region Livros

        private void btnLivros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelLivrosSubMenu);
        }

        private void btnBuscaLivros_Click(object sender, EventArgs e)
        {
            abreMenuForm(new BuscaLivros());
            escondeSubMenu();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            abreMenuForm(new Estoque());
            escondeSubMenu();
        }

        #endregion

        // Botão que leva ao menu de empréstimos
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            MenuEmprestimo menuEmprestimo = new MenuEmprestimo();
            menuEmprestimo.Show();
            this.Hide(); // Oculta a tela atual
        }

        // Botão de relatórios (usa o mesmo form de Estoque, talvez por simplicidade ou placeholder)
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MenuRelatorio menuRelatorio = new MenuRelatorio();
            menuRelatorio.Show();
            this.Hide(); // Oculta a tela atual
        }

        // Formulário atual exibido no painel central
        private Form ativaForm = null;

        // Método para abrir formulário dentro do painel central (sem bordas)
        private void abreMenuForm(Form menuForm)
        {
            if (ativaForm != null)
                ativaForm.Close(); // Fecha form anterior se houver

            ativaForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.FormBorderStyle = FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            panelMenuForm.Controls.Add(menuForm);
            panelMenuForm.Tag = menuForm;
            menuForm.BringToFront();
            menuForm.Show();
        }

        // Botão de sair: confirma saída e volta para tela de login
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você realmente deseja sair?",
                "Confirmação de saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        // Evento disparado ao fechar o formulário principal (encerra a aplicação por completo)
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
