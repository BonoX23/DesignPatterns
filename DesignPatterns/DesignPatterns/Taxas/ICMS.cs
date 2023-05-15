using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;

namespace DesignPatterns.Taxas
{
    public class ICMS : IImposto
    {
        public const double fixo = 50.00;
        public double Calcula(Orcamento orcamento)
        {
            return fixo + orcamento.Valor * 0.05;
        }
    }
}
