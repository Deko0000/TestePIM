using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string NumIdentifica { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Senha { get; set; }

        public Funcionario(string nome, string email, string cpf, DateTime dataNasc, string endereco, string senha)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            Endereco = endereco;
            Senha = senha;
        
        }

       
        public void DefinirIdentificacao()
        {
            var (id, numIdentifica) = GerarIdentificacao.GerarIDFuncionario();
            Id = id;
            NumIdentifica = numIdentifica;
        }
    }
}

