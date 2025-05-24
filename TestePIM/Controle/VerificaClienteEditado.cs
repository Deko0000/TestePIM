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
        public bool Validar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Email) ||
                string.IsNullOrWhiteSpace(cliente.CPF) || string.IsNullOrWhiteSpace(cliente.RA) ||
                string.IsNullOrWhiteSpace(cliente.Endereco) || cliente.DataNasc == DateTime.Now)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            try
            {
                var mail = new System.Net.Mail.MailAddress(cliente.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(cliente.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos (000.000.000-00).");
                return false;
            }

            if (!Regex.IsMatch(cliente.RA, @"^[a-zA-Z0-9]{7}$"))
            {
                MessageBox.Show("RA inválido.");
                return false;
            }

            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - cliente.DataNasc.Year;

            // Ajuste se a data de nascimento ainda não fez aniversário este ano
            if (cliente.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 10)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 10 anos).");
                return false;
            }

            return true;
        }
    }
}
