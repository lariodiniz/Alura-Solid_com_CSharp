using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class SAP : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nota)
        {
            Console.WriteLine("Enviado nota para SAP");
        }
    }
}
