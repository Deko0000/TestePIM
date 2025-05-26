using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePIM.Dados;

namespace TestePIM.Controle.Emprestimo
{
    public class VerificarStatus
    {
        /// <summary>
        /// Verifica se o empréstimo está atrasado comparando a data prevista de devolução com a data atual.
        /// </summary>
        /// <param name="dataPrevista">Data prevista para devolução do livro.</param>
        /// <param name="dataAtual">Data atual para comparação.</param>       
        /// <returns>Retorna true se o empréstimo está atrasado, caso contrário, false.</returns>
        public static bool EstaAtrasado(DateTime dataPrevista, DateTime dataAtual)
        {
            return dataAtual.Date > dataPrevista.Date;
        }

        /// <summary>
        /// Aplica uma multa ao cliente do empréstimo caso haja um funcionário logado.
        /// </summary>
        /// <param name="emprestimo">Empréstimo referente à multa.</param>
        public static void AplicarMulta(TestePIM.Dados.Emprestimo emprestimo)
        {
            // Obtém o funcionário atualmente logado no sistema
            var funcionario = VerificaAdm.FuncionarioLogado;

            if (funcionario != null)
            {
                // Cria uma nova multa associando cliente e funcionário
                var multa = new Multa
                {
                    Cliente = emprestimo.Cliente,
                    Funcionario = funcionario
                };

                // Adiciona a multa à lista de multas do sistema
                Listas.Multas.Add(multa);
            }
            else
            {
                // Lança exceção caso não haja funcionário logado
                throw new Exception("Funcionário não identificado para aplicar multa.");
            }
        }
    }
}
