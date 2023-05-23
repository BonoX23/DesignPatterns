using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstrações
{
    public abstract class TempleateDeImpostoCondicional : IImposto
    {
        public TempleateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto)
        {
        }

        protected TempleateDeImpostoCondicional()
        {
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao (Orcamento orcamento);
        public abstract double MinimaTaxacao (Orcamento orcamento);

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }
    }
}
