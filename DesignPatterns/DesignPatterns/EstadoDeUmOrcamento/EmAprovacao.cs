using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EstadoDeUmOrcamento
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor - 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }
        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }
    }
}
