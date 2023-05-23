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

        public ICMS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return fixo + (orcamento.Valor * 0.05) + CalculaOutroImposto(orcamento);
        }

        private double CalculaOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
