using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Controle.Emprestimo
{
    // Classe responsável por validar os campos necessários para a realização de um empréstimo
    internal class VerificaRealizacaoEmp
    {
        /// <summary>
        /// Verifica se os campos obrigatórios para o empréstimo estão preenchidos corretamente.
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

            // Retorna null caso todos os campos estejam corretos
            return null;
        }
    }
}
