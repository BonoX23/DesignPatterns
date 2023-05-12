using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;

namespace DesignPatterns.Taxas
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orçamento)
        {
            return orçamento.Valor * 0.06;
        }
    }
}
