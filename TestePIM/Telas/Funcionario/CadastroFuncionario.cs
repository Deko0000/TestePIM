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
            InitializeComponent();
        }
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
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // 1. Captura dos dados
            string nome = txbNome.Text;
            string email = txbEmail.Text;
            string cpf = txbCPF.Text;
            DateTime dataNasc = dtpDataNasc.Value;            
            string endereco = txbEndereco.Text;
            string senha = txbSenha.Text;
            string confirmaSenha = txbConfirmaSenha.Text;

            // 2. Cria o objeto Funcionario
            Funcionario funcionario = new Funcionario(nome, email, cpf, dataNasc, endereco, senha);

            VerificaFuncionario verifica = new VerificaFuncionario();

            
            if (verifica.Validar(funcionario, confirmaSenha))
            {
                // 5. Adiciona à lista
                funcionario.DefinirIdentificacao();
                Listas.Funcionarios.Add(funcionario);
                lblIdentificaFuncionario.Text = "Número de Identificação: " + funcionario.NumIdentifica;
                lblIdentificaFuncionario.Visible = true;

                MessageBox.Show("Funcionário" +funcionario.Nome+ " cadastrado com sucesso!");

                // 6. Limpa os campos
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
