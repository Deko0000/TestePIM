using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM
{
    internal class VerificaFuncionario : CadastroFuncionario
    {
        public bool Validar(Funcionario funcionario, string confirmaSenha)
        {
            if (string.IsNullOrWhiteSpace(funcionario.Nome) ||
                string.IsNullOrWhiteSpace(funcionario.Email) ||
                string.IsNullOrWhiteSpace(funcionario.CPF) ||             
                string.IsNullOrWhiteSpace(funcionario.Endereco) ||
                string.IsNullOrWhiteSpace(funcionario.Senha) ||
                string.IsNullOrWhiteSpace(confirmaSenha) ||
                funcionario.DataNasc == DateTime.Now)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            // Validação de e-mail
            try
            {
                var mail = new System.Net.Mail.MailAddress(funcionario.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            // Validação de CPF
            if (!System.Text.RegularExpressions.Regex.IsMatch(funcionario.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos.");
                return false;
            }

            // Confirmação de Senha
            if (funcionario.Senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return false;
            }

            // Verifica se já existe
            if (Listas.Funcionarios.Any(u => u.Email == funcionario.Email))
            {
                MessageBox.Show("Já existe um funcionário com esse e-mail.");
                return false;
            }
            if (Listas.Funcionarios.Any(u => u.CPF == funcionario.CPF))
            {
                MessageBox.Show("Já existe um funcionário com esse CPF.");
                return false;
            }
            if (funcionario.DataNasc.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Data de nascimento inválida.");
                return false;
            }

            return true;
        }
    }
}

