﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class Multa
    {

        public Emprestimo Emprestimo { get; set; }


        public decimal ValorMulta { get; set; }

        // Forma de pagamento utilizada
        public string FormaPagamento { get; set; }


        public bool Pago { get; set; }


        public bool Status { get; set; } // ativo ou resolvido

    }
}
