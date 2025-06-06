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
        // Lista estática que armazena todos os clientes cadastrados
        public static List<Cliente> Clientes { get; } = new List<Cliente>();

        // Lista estática que armazena todos os livros cadastrados
        public static List<Livro> Livros { get; } = new List<Livro>();

        // Lista estática que armazena todos os funcionários cadastrados
        public static List<Funcionario> Funcionarios { get; } = new List<Funcionario>();

        // Lista estática que armazena todos os empréstimos realizados
        public static List<Emprestimo> Emprestimos { get; } = new List<Emprestimo>();

        // Lista estática que armazena todas as multas registradas
        public static List<Multa> Multas { get; } = new List<Multa>();

        // Lista estática que armazena todos os relatórios registrados
        public static List<Relatorio> Relatorios { get; } = new List<Relatorio>();

    }
}
