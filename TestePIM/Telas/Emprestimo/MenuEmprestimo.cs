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
        public MenuEmprestimo()
        {
            InitializeComponent();
           
            
        }

       

        private void escondeSubMenu()
        {
            if (panelEmpSubMenu.Visible == true)
                panelEmpSubMenu.Visible = false;           
        }

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

        
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {            
            mostraSubMenu(panelEmpSubMenu);
        }

        private void btnRealizarEmp_Click(object sender, EventArgs e)
        {
            abreMenuEmpForm(new RealizaEmp());
            escondeSubMenu();
        }

        private void btnAcompanharEmp_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }
        private void btnDevolveEmp_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            escondeSubMenu();
        }
      

        

        public Form ativaForm = null;
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

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();            
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
