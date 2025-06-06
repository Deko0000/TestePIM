using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePIM.Dados;

namespace TestePIM.Dados
{
    public class Relatorio
    {
        // Identificador único do relatório
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }
        public Emprestimo Emprestimo { get; set; }
        public Multa Multa { get; set; }

        public Funcionario Funcionario { get; set; }

        public string LivroMaisEmprestado { get; set; }
        public string AutorMaisEmprestado { get; set; }
        public string GeneroMaisEmprestado { get; set; }
        public int TotalEmprestimos { get; set; }
        public int TotalMultas { get; set; }


        public Relatorio(Cliente cliente = null, Livro livro = null, Emprestimo emprestimo = null, Multa multa = null, Funcionario funcionario = null)
        {
            Cliente = cliente;
            Livro = livro;
            Emprestimo = emprestimo;
            Multa = multa;
            Funcionario = funcionario;
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente?.Nome ?? "N/A"}, " +
                $"Livro: {Livro?.Titulo ?? "N/A"}, " +
                $"Empréstimo: {Emprestimo?.DataEmprestimo.ToShortDateString() ?? "N/A"}, " +
                $"Multa: {Multa?.ValorMulta.ToString("C") ?? "N/A"}" +
                $"Funcionario: {Funcionario?.Nome ?? "N/A"}, ";
        }

        public void DefinirIdentificacao()
        {
            Id = GerarIdentificacao.GerarIDRelat(); // Gera um novo ID para o livro
        }
    }
}