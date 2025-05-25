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

        // Evento de Clique do botão "Confirmar"
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos de texto
            string matricula = txbMatricula.Text;
            string cpf = txbCPF.Text;
            string novaSenha = txbSenha.Text;
            string confirmaSenha = txbConfirmaSenha.Text;

            // Verifica se algum campo está vazio
            if (string.IsNullOrWhiteSpace(matricula) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(novaSenha) ||
                string.IsNullOrWhiteSpace(confirmaSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifica se as senhas são iguais
            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }

            // Verifica se a matrícula e o CPF são válidos
            var funcionarioEncontrado = Listas.Funcionarios
                .FirstOrDefault(f => f.NumIdentifica == matricula && f.CPF == cpf);


            // Se o funcionário for encontrado, altera a senha
            if (funcionarioEncontrado != null)
            {
                funcionarioEncontrado.Senha = novaSenha;
                MessageBox.Show("Senha alterada com sucesso!");                
                this.Close();
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado. Verifique os dados informados.");
            }
            
        }

        // Evento de Clique do botão "Voltar"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();            
            
        }
        // Evento de Clique do botão "Fechar"
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
