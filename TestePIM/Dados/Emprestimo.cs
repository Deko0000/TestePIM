using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class Emprestimo
    {
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool Status { get; set; } // true = ativo, false = devolvido
    }
}
