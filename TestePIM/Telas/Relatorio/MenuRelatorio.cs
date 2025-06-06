using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Telas.Relatorio;

namespace TestePIM.Telas.Relatorio
{
    public partial class MenuRelatorio : Form
    {
        // Construtor do formulário de Menu de Empréstimos
        public MenuRelatorio()
        {
            InitializeComponent();
            btnGerenciaRelat.Visible = false;         
           
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            // Exibe botões extras apenas se o usuário logado for administrador
            if (VerificaAdm.IsAdmin)
            {               
                btnGerenciaRelat.Visible = true;                
            }
        }

        // Oculta o submenu de empréstimos, se estiver visível
        private void escondeSubMenu()
        {
            if (panelRelatClienteSubMenu.Visible == true)
                panelRelatClienteSubMenu.Visible = false;            
        }

        // Exibe ou oculta o submenu passado como parâmetro
        private void mostraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escondeSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnRelatClientes_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelRelatClienteSubMenu);            
        }        

        private void btnRelatClienteEsp_Click(object sender, EventArgs e)
        {
            abreMenuRelatForm(new RelatClienteEsp());
            escondeSubMenu();
        }

        private void btnRelatFun_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelRelatFunSubMenu);
            
        }        

        private void btnRelatFunEsp_Click(object sender, EventArgs e)
        {
            abreMenuRelatForm(new RelatFunEsp());
            escondeSubMenu();
        }

        private void btnRelatLivros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelRelatLivroSubMenu);
            
        }

        private void btnRelatLivro_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnRelatLivroEsp_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnGerenciaRelat_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }


        // Guarda referência ao formulário ativo dentro do painel
        public Form ativaForm = null;

        // Abre um formulário dentro do painel principal, fechando o anterior se houver
        public void abreMenuRelatForm(Form menuForm)
        {
            if (ativaForm != null)
                ativaForm.Close();
            ativaForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.FormBorderStyle = FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            panelMenuRelatForm.Controls.Add(menuForm);
            panelMenuRelatForm.Tag = menuForm;
            menuForm.BringToFront();
            menuForm.Show();
        }

        // Evento do botão "Voltar": retorna ao menu principal
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        // Evento disparado ao fechar o formulário: encerra a aplicação
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }        
    }
}
