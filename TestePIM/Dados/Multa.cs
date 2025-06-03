using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class Multa
    {
        public Emprestimo Emprestimo { get; set; }  // referência ao empréstimo original

        public decimal ValorMulta { get; set; }  // multa calculada por atraso
        
        public bool Pago { get; set; } // indica se a multa foi paga

        public bool Status { get; set; } // ativo ou resolvido
    }
}
