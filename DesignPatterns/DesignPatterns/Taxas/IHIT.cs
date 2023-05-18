using DesignPatterns.Abstrações;
using DesignPatterns.Orçamento;

namespace DesignPatterns.Taxas
{
    public class IHIT : TempleateDeImpostoCondicional
    {
        private const double taxaextra = 100.00;
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + taxaextra;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
