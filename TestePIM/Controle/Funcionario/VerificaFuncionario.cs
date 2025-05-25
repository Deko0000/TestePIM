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
        // Método responsável por validar os dados do funcionário antes do cadastro
        public bool Validar(Funcionario funcionario, string confirmaSenha)
        {
            // Verifica se algum campo obrigatório está vazio ou se a data de nascimento não foi alterada
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

            // Validação de e-mail usando System.Net.Mail.MailAddress
            try
            {
                var mail = new System.Net.Mail.MailAddress(funcionario.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            // Validação de CPF: deve conter exatamente 11 dígitos numéricos
            if (!System.Text.RegularExpressions.Regex.IsMatch(funcionario.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos.");
                return false;
            }

            // Confirmação de Senha: verifica se a senha e a confirmação são iguais
            if (funcionario.Senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return false;
            }

            // Verifica se já existe um funcionário com o mesmo e-mail
            if (Listas.Funcionarios.Any(u => u.Email == funcionario.Email))
            {
                MessageBox.Show("Já existe um funcionário com esse e-mail.");
                return false;
            }
            // Verifica se já existe um funcionário com o mesmo CPF
            if (Listas.Funcionarios.Any(u => u.CPF == funcionario.CPF))
            {
                MessageBox.Show("Já existe um funcionário com esse CPF.");
                return false;
            }

            // Calcula a idade do funcionário
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - funcionario.DataNasc.Year;
            if (funcionario.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            // Verifica se a idade é menor que 14 anos
            if (idade < 14)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 14 anos).");
                return false;
            }

            // Se todas as validações passarem, retorna true
            return true;
        }
    }
}

