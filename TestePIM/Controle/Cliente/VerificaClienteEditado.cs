using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    internal class VerificaClienteEditado
    {
        // Método responsável por validar os dados do cliente editado
        public bool Validar(Cliente cliente)
        {
            // Verifica se algum campo obrigatório está vazio ou se a data de nascimento é igual à data atual
            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Email) ||
                string.IsNullOrWhiteSpace(cliente.CPF) || string.IsNullOrWhiteSpace(cliente.RA) ||
                string.IsNullOrWhiteSpace(cliente.Endereco) || cliente.DataNasc == DateTime.Now)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            try
            {
                // Valida o formato do e-mail
                var mail = new System.Net.Mail.MailAddress(cliente.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            // Verifica se o CPF possui exatamente 11 dígitos numéricos
            if (!System.Text.RegularExpressions.Regex.IsMatch(cliente.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos (000.000.000-00).");
                return false;
            }

            // Verifica se o RA possui exatamente 7 caracteres alfanuméricos
            if (!Regex.IsMatch(cliente.RA, @"^[a-zA-Z0-9]{7}$"))
            {
                MessageBox.Show("RA inválido.");
                return false;
            }

            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - cliente.DataNasc.Year;

            // Ajusta a idade caso o cliente ainda não tenha feito aniversário no ano atual
            if (cliente.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            // Verifica se o cliente possui pelo menos 10 anos de idade
            if (idade < 10)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 10 anos).");
                return false;
            }

            // Se todas as validações passarem, retorna verdadeiro
            return true;
        }
    }
}
