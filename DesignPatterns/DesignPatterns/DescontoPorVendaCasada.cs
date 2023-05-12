using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (aconteceuVendaCasada(orcamento)) return orcamento.Valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        public bool existe(string nomedoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomedoItem))
                    return true;
            }
            return false;
        }

        private bool aconteceuVendaCasada(Orcamento orcamento)
        {
            return existe("Lápis", orcamento) && existe("Caneta", orcamento);
        }

    }
}

//public class DescontoPorVendaCasada : Desconto
//{
//    public Desconto Proximo { get; set; }
//    public double Calcula(Orcamento orcamento)
//    {
//        if (aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.05;
//        else return proximo.Calcula(orcamento);
//    }

//    private bool aconteceuVendaCasadaEm(Orcamento orcamento)
//    {
//        return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
//    }
