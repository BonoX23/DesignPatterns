﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;

namespace DesignPatterns.Taxas
{
    public class ICCC : IImposto
    {
        const double extra = 30.00;
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor <= 1000.00)
            {
                return 0.05 * orcamento.Valor;
            }

            else if (orcamento.Valor > 1000.00 || orcamento.Valor <= 3000.00)
            {
                return 0.07 * orcamento.Valor;
            }

            else
            {
                return 0.08 * orcamento.Valor + extra;
            }
        }
    }
}
