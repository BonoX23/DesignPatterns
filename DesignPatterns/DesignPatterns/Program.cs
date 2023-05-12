using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Calculador;
using DesignPatterns.Orçamento;

namespace DesignPatterns
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Imposto iss = new ISS();
        //    Imposto icms = new ICMS();

        //    Orcamento orcamento = new Orcamento(500.00);

        //    CalculadoraDeImpostos calculador = new CalculadoraDeImpostos();

        //    calculador.RealizaCalculo(orcamento, icms);
        //    calculador.RealizaCalculo(orcamento, iss);

        //    Console.ReadKey();
        //}

        static void Main(String[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(100.00);
            orcamento.AdicionaItem(new Item("Lápis", 90.00));
            //orcamento.AdicionaItem(new Item("Borracha", 350.00));
            //orcamento.AdicionaItem(new Item("Apontador", 500.00));
            //orcamento.AdicionaItem(new Item("Régua", 450.00));
            orcamento.AdicionaItem(new Item("Caneta", 90.00));
            orcamento.AdicionaItem(new Item("Caneta", 90.00));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();

        }

        //static void Main(String[] args)
        //{
        //    Orcamento orcamento = new Orcamento(500.0);

        //    IDesconto d1 = new DescontoPorCincoItens();
        //    IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
        //    IDesconto d3 = new DescontoPorVendaCasada();
        //    IDesconto d4 = new SemDesconto();

        //    d1.Proximo = d2;
        //    d2.Proximo = d3;
        //    d3.Proximo = d4;


        //    double desconto = d1.Desconta(orcamento);
        //    Console.WriteLine(desconto);
        //}
    }
}