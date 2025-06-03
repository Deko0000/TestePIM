using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Controle.Emprestimo
{
    internal class VerificaRealizacaoEmp
    {
        /// <summary>
        /// Verifica se os campos obrigatórios para o empréstimo estão preenchidos corretamente
        /// e se o cliente está apto a fazer o empréstimo com base em regras de negócio.
        /// </summary>
        /// <param name="livro">Objeto do tipo Livro selecionado para empréstimo</param>
        /// <param name="cliente">Objeto do tipo Cliente que irá realizar o empréstimo</param>
        /// <param name="dataEmprestimo">Data em que o empréstimo está sendo realizado</param>
        /// <param name="dataDevolucao">Data prevista para devolução do livro</param>
        /// <returns>Mensagem de erro caso algum campo esteja inválido, ou null se estiver tudo correto</returns>
        public static string VerificarCampos(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            // Verifica se algum livro foi selecionado
            if (livro == null)
                return "Nenhum livro foi selecionado.";

            // Verifica se algum cliente foi selecionado
            if (cliente == null)
                return "Nenhum cliente foi selecionado.";

            // Verifica se as informações essenciais do livro estão preenchidas
            if (string.IsNullOrWhiteSpace(livro.Titulo) || string.IsNullOrWhiteSpace(livro.Autor))
                return "Informações do livro estão incompletas.";

            // Verifica se as informações essenciais do cliente estão preenchidas
            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.RA))
                return "Informações do cliente estão incompletas.";

            // Verifica se a data de devolução não é anterior à data de empréstimo
            if (dataDevolucao.Date < dataEmprestimo.Date)
                return "A data de devolução não pode ser anterior à data de empréstimo.";

            // Verifica quantos livros o cliente já tem emprestados (ativos)
            int emprestimosAtivos = Listas.Emprestimos
                .Count(e => e.Cliente.RA == cliente.RA && e.Status);

            if (emprestimosAtivos >= 5)
                return "O cliente já possui o limite de 5 livros emprestados.";

            // Verifica se o cliente já possui o mesmo livro emprestado e ainda não devolveu
            bool mesmoLivroEmprestado = Listas.Emprestimos
                .Any(e => e.Cliente.RA == cliente.RA && e.Livro.Id == livro.Id && e.Status);

            if (mesmoLivroEmprestado)
                return "Este cliente já possui um exemplar deste livro emprestado.";

            if (dataDevolucao > dataEmprestimo.AddDays(30))
            {
                return "A data de devolução não pode ser mais de 30 dias após a data de empréstimo.";
            }

            // Tudo OK
            return null;
        }
    }
}
