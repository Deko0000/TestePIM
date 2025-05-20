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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelCadastrosSubMenu.Visible = false;
            panelLivrosSubMenu.Visible = false;
            panelEmpSubMenu.Visible = false;
            panelRelatSubMenu.Visible = false;           

        }

        private void escondeSubMenu()
        {
            if (panelCadastrosSubMenu.Visible == true)
                panelCadastrosSubMenu.Visible = false;
            if (panelLivrosSubMenu.Visible == true)
                panelLivrosSubMenu.Visible = false;
            if (panelEmpSubMenu.Visible == true)
                panelEmpSubMenu.Visible = false;
            if (panelRelatSubMenu.Visible == true)
                panelRelatSubMenu.Visible = false;
        }

        private void mostraSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                escondeSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelCadastrosSubMenu);
        }

        private void btnCadastroLivros_Click(object sender, EventArgs e)
        {
            abreMenuForm(new CadastroLivros());
            escondeSubMenu();
        }

        private void btnCadastroUsuarios_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelLivrosSubMenu);
        }

        private void btnBuscaLivros_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelEmpSubMenu);
        }

        private void btnRealizarEmp_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnAcompanharEmp_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelRelatSubMenu);
        }

        private void btnRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnRelatórioLivros_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnGerenciaRelat_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private Form ativaForm = null;
        private void abreMenuForm(Form menuForm)
        {
            if (ativaForm != null)
                ativaForm.Close();
            ativaForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.FormBorderStyle  = FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            panelMenuForm.Controls.Add(menuForm);
            panelMenuForm.Tag = menuForm;
            menuForm.BringToFront();
            menuForm.Show();
        }
    }
}
