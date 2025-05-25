using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Cliente
    {
        // Propriedade que armazena o nome do cliente
        public string Nome { get; set; }
        // Propriedade que armazena o e-mail do cliente
        public string Email { get; set; }
        // Propriedade que armazena o CPF do cliente
        public string CPF { get; set; }
        // Propriedade que armazena a data de nascimento do cliente
        public DateTime DataNasc { get; set; }
        // Propriedade que armazena o RA (Registro Acadêmico) do cliente
        public string RA { get; set; }
        // Propriedade que armazena o endereço do cliente
        public string Endereco { get; set; }

        // Construtor que inicializa as propriedades do cliente
        public Cliente(string nome, string email, string cpf, DateTime dataNasc, string ra, string endereco)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            RA = ra;
            Endereco = endereco;
        }
    }

}
