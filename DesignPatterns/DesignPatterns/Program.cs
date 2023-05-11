using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Orcamento orcamento = new Orcamento(500.00);
            orcamento.AdicionaItem(new Item("Lápis", 250.00));
            orcamento.AdicionaItem(new Item("Borracha", 350.00));
            orcamento.AdicionaItem(new Item("Apontador", 500.00));
            orcamento.AdicionaItem(new Item("Régua", 450.00));
            orcamento.AdicionaItem(new Item("Caneta", 550.00));
            orcamento.AdicionaItem(new Item("Caneta", 550.00));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();

        }
    }
}