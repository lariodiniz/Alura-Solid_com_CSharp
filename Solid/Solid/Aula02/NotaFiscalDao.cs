using System;

namespace Solid
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {

        public void Executa(NotaFiscal nota)
        {
            Console.WriteLine("Persistindo nota");
        }
    }

}