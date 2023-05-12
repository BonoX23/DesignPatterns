﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;

namespace DesignPatterns.Taxas
{
    public class ICMS : Imposto
    {
        public const double fixo = 50.00;
        public double Calcula(Orcamento orçamento)
        {
            return fixo + orçamento.Valor * 0.05;
        }
    }
}