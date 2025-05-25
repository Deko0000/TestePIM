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
        // Método responsável por validar os dados do funcionário editado
        public bool Validar(Funcionario funcionario, string confirmaSenha)
        {
            // Verifica se algum campo obrigatório está vazio ou inválido
            if (string.IsNullOrWhiteSpace(funcionario.Nome) || string.IsNullOrWhiteSpace(funcionario.Email) ||
                string.IsNullOrWhiteSpace(funcionario.CPF) || string.IsNullOrWhiteSpace(funcionario.Endereco) ||
                string.IsNullOrEmpty(funcionario.Senha) || string.IsNullOrWhiteSpace(confirmaSenha) ||
                funcionario.DataNasc == DateTime.Now)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            try
            {
                // Valida o formato do e-mail
                var mail = new System.Net.Mail.MailAddress(funcionario.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            // Verifica se o CPF possui exatamente 11 dígitos numéricos
            if (!System.Text.RegularExpressions.Regex.IsMatch(funcionario.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos (000.000.000-00).");
                return false;
            }

            // Verifica se as senhas coincidem
            if (funcionario.Senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return false;
            }

            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - funcionario.DataNasc.Year;

            // Ajusta a idade caso o aniversário ainda não tenha ocorrido no ano atual
            if (funcionario.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            // Verifica se o funcionário possui pelo menos 14 anos
            if (idade < 14)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 14 anos).");
                return false;
            }

            // Todos os critérios de validação foram atendidos
            return true;
        }
    }
}
