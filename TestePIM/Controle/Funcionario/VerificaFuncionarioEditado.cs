using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    internal class VerificaFuncionarioEditado
    {
        public bool Validar(Funcionario funcionario, string confirmaSenha)
        {
            if (string.IsNullOrWhiteSpace(funcionario.Nome) || string.IsNullOrWhiteSpace(funcionario.Email) ||
                string.IsNullOrWhiteSpace(funcionario.CPF) ||  string.IsNullOrWhiteSpace(funcionario.Endereco) || 
                string.IsNullOrEmpty(funcionario.Senha) || string.IsNullOrWhiteSpace(confirmaSenha) || 
                funcionario.DataNasc == DateTime.Now)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            try
            {
                var mail = new System.Net.Mail.MailAddress(funcionario.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(funcionario.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos (000.000.000-00).");
                return false;
            }

            if (funcionario.Senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return false;
            }

            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - funcionario.DataNasc.Year;

            // Ajuste se a data de nascimento ainda não fez aniversário este ano
            if (funcionario.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 14)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 14 anos).");
                return false;
            }

            return true;
        }
    }
}
