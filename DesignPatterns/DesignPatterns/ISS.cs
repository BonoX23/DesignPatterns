using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orçamento)
        {
            return orçamento.Valor * 0.06;
        }
    }
}
