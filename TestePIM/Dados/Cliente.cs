using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Cliente
    {
        

        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string RA { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string email, string cpf, DateTime dataNasc, string ra, string endereco)
        {           

            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            RA = ra;
            Endereco = endereco;            
            
            
        }
        public void DefinirIdentificacao()
        {

            Id = GerarIdentificacao.GerarIDCliente();
        }

    }

}
