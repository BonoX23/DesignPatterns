using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MethodChaining
{
    public class ItemDaNota
    {
        public string Nome { get; set; }
        public double Valor { get; set; } 
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
