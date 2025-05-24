using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Controle.Emprestimo
{
    internal class VerificaRealizacaoEmp
    {
        public static string VerificarCampos(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            if (livro == null)
                return "Nenhum livro foi selecionado.";

            if (cliente == null)
                return "Nenhum cliente foi selecionado.";

            if (string.IsNullOrWhiteSpace(livro.Titulo) || string.IsNullOrWhiteSpace(livro.Autor))
                return "Informações do livro estão incompletas.";

            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.RA))
                return "Informações do cliente estão incompletas.";

            if (dataDevolucao.Date < dataEmprestimo.Date)
                return "A data de devolução não pode ser anterior à data de empréstimo.";

            return null; // Tudo certo
        }
    }
}
