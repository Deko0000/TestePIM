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
        /// Verifica se a data de devolução está atrasada em relação à data prevista.
        /// </summary>
        public static bool EstaAtrasado(DateTime dataPrevista, DateTime dataDevolvida)
        {
            return dataDevolvida.Date > dataPrevista.Date;
        }

        /// <summary>
        /// Aplica multa apenas para empréstimos que foram devolvidos com atraso.
        /// </summary>
        public static void AplicarMulta(TestePIM.Dados.Emprestimo emprestimo)
        {
            var funcionario = VerificaAdm.FuncionarioLogado;

            if (funcionario == null)
                throw new Exception("Nenhum funcionário ou administrador identificado para aplicar multa.");

            // Só aplica multa se o livro já foi devolvido
            if (!emprestimo.DataDevolvida.HasValue)
                return;

            DateTime dataDevolvida = emprestimo.DataDevolvida.Value;

            if (EstaAtrasado(emprestimo.DataParaDevolucao, dataDevolvida))
            {
                int diasAtraso = (dataDevolvida.Date - emprestimo.DataParaDevolucao.Date).Days;
                decimal valorMulta = diasAtraso * 1.00m;

                // Verifica se já existe multa para esse empréstimo
                if (!Listas.Multas.Any(m => m.Emprestimo == emprestimo))
                {
                    var novaMulta = new Multa
                    {
                        Emprestimo = emprestimo,
                        ValorMulta = valorMulta,
                        Pago = false,
                        Status = true
                    };

                    Listas.Multas.Add(novaMulta);
                }
            }
        }
    }
}

