using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 01 
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);

            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O Salario de um desenvolvedor que ganha 2000 bruto é: " + resultado);
            Console.ReadKey();
            */

            /* Aula 02 */

            EnviadorDeEmail enviadorEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(enviadorEmail);
            acoes.Add(nfDao);
            acoes.Add(new SAP());


            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(2000, "Renan Sergio");
            gnf.Gera(fatura);
            Console.ReadKey();

        }
    }
}
