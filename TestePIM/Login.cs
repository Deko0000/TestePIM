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
        public Login()
        {
            InitializeComponent();
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
