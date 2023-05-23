using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;

namespace DesignPatterns.Taxas
{
    public class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto(IImposto outroImposto) : base(outroImposto)
        {
        }
        public ImpostoMuitoAlto()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculaOutroImposto(orcamento);
        }
        private double CalculaOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
