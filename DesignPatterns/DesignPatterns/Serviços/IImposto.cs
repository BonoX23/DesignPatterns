using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;

namespace DesignPatterns.Serviços
{
    public abstract class IImposto
    {
        public readonly IImposto OutroImposto;

        public IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public IImposto()
        {
            OutroImposto = null;
        }

        public virtual double CalculaOutroImposto(Orcamento orcamento)
        {
            return OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
