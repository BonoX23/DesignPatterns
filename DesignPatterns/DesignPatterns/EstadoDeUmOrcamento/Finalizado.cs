using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EstadoDeUmOrcamento
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
    }
}
