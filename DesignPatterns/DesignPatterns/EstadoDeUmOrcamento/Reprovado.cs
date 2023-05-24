using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EstadoDeUmOrcamento
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }

}
