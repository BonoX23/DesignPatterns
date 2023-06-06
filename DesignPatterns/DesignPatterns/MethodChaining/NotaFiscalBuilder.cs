using DesignPatterns.Orçamento;
using DesignPatterns.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MethodChaining
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal notaFiscal);
    }

    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }

    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }

    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorTotal * Fator);  
        }
    }

    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }

        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public IList<IAcaoAposGerarNota> TodasAsAcoesASeremExecutas;

        public NotaFiscalBuilder()
        {
            this.TodasAsAcoesASeremExecutas = new List<IAcaoAposGerarNota>();
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this.TodasAsAcoesASeremExecutas.Add(novaAcao);
        }

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
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal,
                                Impostos, TodosItens, Observacoes);

            foreach(IAcaoAposGerarNota acao in TodasAsAcoesASeremExecutas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        class Teste
        {
            public static void Main(String[] args)
            {
                NotaFiscalBuilder builder = new NotaFiscalBuilder();
                builder.AdicionaAcao(new EnviadorDeEmail());
                builder.AdicionaAcao(new NotaFiscalDao());
                builder.AdicionaAcao(new Multiplicador(4.4));

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
