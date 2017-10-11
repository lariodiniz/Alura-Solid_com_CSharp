using System;

namespace Solid
{
    public class EnviadorDeEmail: IAcaoAposGerarNota
    {

        public void Executa(NotaFiscal nota)
        {
            Console.WriteLine("Enviando Email");
        }
    }
}