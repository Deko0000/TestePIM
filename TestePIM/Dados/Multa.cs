using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class Multa
    {
<<<<<<< HEAD
        public Emprestimo Emprestimo { get; set; }
        public decimal ValorMulta { get; set; }

        public bool Pago { get; set; } = false;


       
=======
        public Emprestimo Emprestimo { get; set; }  // referência ao empréstimo original

        public decimal ValorMulta { get; set; }  // multa calculada por atraso
        
        public bool Pago { get; set; } // indica se a multa foi paga

        public bool Status { get; set; } // ativo ou resolvido
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6
    }
}
