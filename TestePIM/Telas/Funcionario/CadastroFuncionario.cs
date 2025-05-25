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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent(); // Inicializa os componentes da interface gráfica
        }

        // Evento para mostrar ou ocultar a senha digitada
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

        // Evento para mostrar ou ocultar a confirmação de senha
        private void cbxMostraSenha2_CheckedChanged(object sender, EventArgs e)
        {
            if (txbConfirmaSenha.PasswordChar == '*')
            {
                txbConfirmaSenha.PasswordChar = '\0'; // Mostra a senha                
            }
            else
            {
                txbConfirmaSenha.PasswordChar = '*'; // Oculta a senha
            }
        }

        // Evento do botão "Cadastrar"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // 1. Captura dos dados dos campos da tela
            string nome = txbNome.Text;
            string email = txbEmail.Text;
            string cpf = txbCPF.Text;
            DateTime dataNasc = dtpDataNasc.Value;
            string endereco = txbEndereco.Text;
            string senha = txbSenha.Text;
            string confirmaSenha = txbConfirmaSenha.Text;

            // 2. Cria o objeto Funcionario com os dados informados
            Funcionario funcionario = new Funcionario(nome, email, cpf, dataNasc, endereco, senha);

            VerificaFuncionario verifica = new VerificaFuncionario();

            // 3. Valida os dados do funcionário e a confirmação de senha
            if (verifica.Validar(funcionario, confirmaSenha))
            {
                // 4. Gera o número de identificação do funcionário
                funcionario.DefinirIdentificacao();

                // 5. Adiciona o funcionário à lista global
                Listas.Funcionarios.Add(funcionario);

                // 6. Exibe o número de identificação na tela
                lblIdentificaFuncionario.Text = "Número de Identificação: " + funcionario.NumIdentifica;
                lblIdentificaFuncionario.Visible = true;

                // 7. Mostra mensagem de sucesso
                MessageBox.Show("Funcionário" + funcionario.Nome + " cadastrado com sucesso!");

                // 8. Limpa os campos do formulário
                txbNome.Clear();
                txbEmail.Clear();
                txbCPF.Clear();
                dtpDataNasc.Value = DateTime.Now;
                txbEmail.Clear();
                txbEndereco.Clear();
                txbSenha.Clear();
                txbConfirmaSenha.Clear();
                lblIdentificaFuncionario.Visible = false;
            }
        }

        // Evento do botão "Limpar" para limpar todos os campos do formulário
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbCPF.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txbEmail.Clear();
            txbEndereco.Clear();
            txbSenha.Clear();
            txbConfirmaSenha.Clear();
        }

        // Evento do botão "Voltar" para fechar a tela de cadastro
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
