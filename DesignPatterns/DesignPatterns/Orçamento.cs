using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
    public class Item
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
