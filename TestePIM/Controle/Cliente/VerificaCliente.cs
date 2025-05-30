﻿using System;
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
        /// <summary>
        /// Valida os dados do cliente recebido como parâmetro.
        /// </summary>
        /// <param name="cliente">Objeto Cliente a ser validado</param>
        /// <returns>True se todos os dados forem válidos, False caso contrário</returns>
        public bool Validar(Cliente cliente)
        {
            // Verifica se algum campo obrigatório está vazio ou nulo
            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Email) ||
                string.IsNullOrWhiteSpace(cliente.CPF) || string.IsNullOrWhiteSpace(cliente.RA) ||
                string.IsNullOrWhiteSpace(cliente.Endereco))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            // Valida o formato do e-mail
            try
            {
                var mail = new System.Net.Mail.MailAddress(cliente.Email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }

            // Valida o formato do CPF (apenas 11 dígitos)
            if (!System.Text.RegularExpressions.Regex.IsMatch(cliente.CPF, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Use apenas 11 dígitos (000.000.000-00).");
                return false;
            }

            // Valida o formato do RA (7 caracteres alfanuméricos)
            if (!Regex.IsMatch(cliente.RA, @"^[a-zA-Z0-9]{7}$"))
            {
                MessageBox.Show("RA inválido.");
                return false;
            }

            // Verifica se já existe um cliente com o mesmo RA
            if (Listas.Clientes.Any(u => u.RA == cliente.RA))
            {
                MessageBox.Show("Já existe um cliente com esse RA.");
                return false;
            }

            // Verifica se já existe um cliente com o mesmo e-mail
            if (Listas.Clientes.Any(u => u.Email == cliente.Email))
            {
                MessageBox.Show("Já existe um cliente com esse e-mail.");
                return false;
            }

            // Verifica se já existe um cliente com o mesmo CPF
            if (Listas.Clientes.Any(u => u.CPF == cliente.CPF))
            {
                MessageBox.Show("Já existe um cliente com esse CPF.");
                return false;
            }

            // Calcula a idade do cliente
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - cliente.DataNasc.Year;
            if (cliente.DataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            // Verifica se a idade é menor que 10 anos
            if (idade < 10)
            {
                MessageBox.Show("Data de Nascimento inválida (Min 10 anos).");
                return false;
            }

            // Todos os dados são válidos
            return true;
        }
    }

}


