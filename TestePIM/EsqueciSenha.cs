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
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string cpf = txbCPF.Text;
            string novaSenha = txbSenha.Text;
            string confirmaSenha = txbConfirmaSenha.Text;

            var funcionarioEncontrado = Listas.Funcionarios
                .FirstOrDefault(f => f.Email == email && f.CPF == cpf);
            
            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }

            if (funcionarioEncontrado != null)
            {
                funcionarioEncontrado.Senha = novaSenha;
                MessageBox.Show("Senha alterada com sucesso!");
                this.Close();  // ou limpar os campos, ou voltar para tela de login
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado. Verifique os dados informados.");
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
