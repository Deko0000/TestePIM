using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TestePIM
{
    public class VerificaCliente   
    {
        
            public bool Validar(Cliente cliente)
            {
                if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Email) ||
                    string.IsNullOrWhiteSpace(cliente.CPF) || string.IsNullOrWhiteSpace(cliente.RA) ||
                    string.IsNullOrWhiteSpace(cliente.Endereco))
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
                if (Listas.Clientes.Any(u => u.RA == cliente.RA))
                {
                    MessageBox.Show("Já existe um cliente com esse RA.");
                    return false;
                }

            if (Listas.Clientes.Any(u => u.Email == cliente.Email))
                {
                    MessageBox.Show("Já existe um cliente com esse e-mail.");
                    return false;
                }
                if (Listas.Clientes.Any(u => u.CPF == cliente.CPF))
                {
                    MessageBox.Show("Já existe um cliente com esse CPF.");
                    return false;
                }

                return true;
            }
    }

}


