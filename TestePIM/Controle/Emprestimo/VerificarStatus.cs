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
            var funcionario = VerificaAdm.FuncionarioLogado;

            if (funcionario != null)
            {
                // Verifica se o empréstimo está atrasado
                if (EstaAtrasado(emprestimo.DataParaDevolucao, DateTime.Now))
                {
                    // Calcula dias de atraso
                    int diasAtraso = (DateTime.Now.Date - emprestimo.DataParaDevolucao.Date).Days;

                    // Calcula valor da multa (R$1,00 por dia de atraso)
                    decimal valorMulta = diasAtraso * 1.00m;

                    // Cria e registra a multa
                    var multa = new Multa
                    {
                        Emprestimo = emprestimo,
                        ValorMulta = valorMulta
                    };


                    Listas.Multas.Add(multa);
                }
            }
            else
            {
                throw new Exception("Funcionário não identificado para aplicar multa.");
            }
        }
    }
}
