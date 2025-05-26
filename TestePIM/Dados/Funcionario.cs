using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Funcionario
    {
        // Propriedade que armazena o ID único do funcionário
        public int Id { get; set; }

        // Propriedade que armazena o número de identificação do funcionário
        public string NumIdentifica { get; set; }

        // Nome do funcionário
        public string Nome { get; set; }

        // E-mail do funcionário
        public string Email { get; set; }

        // CPF do funcionário
        public string CPF { get; set; }

        // Data de nascimento do funcionário
        public DateTime DataNasc { get; set; }

        // Endereço do funcionário
        public string Endereco { get; set; }

        // Senha do funcionário
        public string Senha { get; set; }

        // Construtor que inicializa as propriedades principais do funcionário
        public Funcionario(string nome, string email, string cpf, DateTime dataNasc, string endereco, string senha)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            Endereco = endereco;
            Senha = senha;
        }

        // Método responsável por gerar e definir o ID e número de identificação do funcionário
        public void DefinirIdentificacao()
        {
            var (id, numIdentifica) = GerarIdentificacao.GerarIDFuncionario();
            Id = id;
            NumIdentifica = numIdentifica;
        }
    }
}

