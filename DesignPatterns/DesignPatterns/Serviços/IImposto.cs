using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Orçamento;

namespace DesignPatterns.Serviços
{
    public interface IImposto
    {
        public double Calcula(Orcamento orcamento);
    }
}
