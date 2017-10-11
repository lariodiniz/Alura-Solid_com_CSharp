using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid
{
    class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> Acoes;        

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> Acoes)
        {
            this.Acoes = Acoes;            
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobre0(valor));

            foreach (IAcaoAposGerarNota acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobre0(double valor)
        {
            return valor * 0.6;
        }
    }
}
