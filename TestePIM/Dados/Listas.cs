using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePIM.Dados;

namespace TestePIM
{
    public class Listas
    {
        public static List<Cliente> Clientes { get; } = new List<Cliente>();
        public static List<Livro> Livros { get; } = new List<Livro>();
        public static List<Funcionario> Funcionarios { get; } = new List<Funcionario>();
        public static List<Emprestimo> Emprestimos { get; } = new List<Emprestimo>();
    }
}
