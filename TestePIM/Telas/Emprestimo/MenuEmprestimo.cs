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
using TestePIM.Telas.Emprestimo;

namespace TestePIM.Telas
{
    public partial class MenuEmprestimo : Form
    {
        // Construtor do formulário de Menu de Empréstimos
        public MenuEmprestimo()
        {
            InitializeComponent();
        }

        // Oculta o submenu de empréstimos, se estiver visível
        private void escondeSubMenu()
        {
            if (panelEmpSubMenu.Visible == true)
                panelEmpSubMenu.Visible = false;
            if (panelPagaSubMenu.Visible == true)
                panelPagaSubMenu.Visible = false;
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

        // Evento do botão principal de Empréstimos: mostra/oculta submenu
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelEmpSubMenu);
            
        }

        // Evento do botão "Realizar Empréstimo": abre tela de realizar empréstimo
        private void btnRealizarEmp_Click(object sender, EventArgs e)
        {
            abreMenuEmpForm(new RealizaEmp());
            escondeSubMenu();
        }

        // Evento do botão "Acompanhar Empréstimo": abre tela de acompanhamento
        private void btnAcompanharEmp_Click(object sender, EventArgs e)
        {
            abreMenuEmpForm(new AcompanhaEmp());
        }

        // Evento do botão "Devolver Empréstimo": abre tela de devolução
        private void btnDevolveEmp_Click(object sender, EventArgs e)
        {
            abreMenuEmpForm(new DevoluEmp());
            escondeSubMenu();
        }

        // Evento do botão "Multas": apenas esconde submenu (pode ser expandido futuramente)
        private void btnMultas_Click(object sender, EventArgs e)
        {
            abreMenuEmpForm(new Multas());
            escondeSubMenu();
        }
        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelPagaSubMenu);
        }        

        // Guarda referência ao formulário ativo dentro do painel
        public Form ativaForm = null;

        // Abre um formulário dentro do painel principal, fechando o anterior se houver
        public void abreMenuEmpForm(Form menuForm)
        {
            if (ativaForm != null)
                ativaForm.Close();
            ativaForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.FormBorderStyle = FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            panelMenuEmpForm.Controls.Add(menuForm);
            panelMenuEmpForm.Tag = menuForm;
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
