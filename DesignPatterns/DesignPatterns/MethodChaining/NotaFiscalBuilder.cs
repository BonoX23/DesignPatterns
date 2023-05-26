using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MethodChaining
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }

        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal,
                                Impostos, TodosItens, Observacoes);
        }

        class Teste
        {
            public static void Main(String[] args)
            {
                NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")
                                  .ComCnpj("123.456.789/0001-10")
                                  .ComItem(new ItemDaNota("item 1", 100.0))
                                  .ComItem(new ItemDaNota("item 2", 200.0))
                                  .ComItem(new ItemDaNota("item 3", 300.0))
                                  .ComObservacoes("entregar nf pessoalmente")
                                  .NaDataAtual()
                                  .Constroi();

                Console.WriteLine(nf.ValorTotal);
            }
        }
    }
}
