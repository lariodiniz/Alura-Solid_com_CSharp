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

            /* Aula 02 

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
            */

            /* Aula 03 

            Compra compra = new Compra(500, "sao paulo");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            double resuldado = calc.Calcula(compra);

            Console.WriteLine("O preço da compra é: "+ resuldado);
            Console.ReadKey();
            */

            /* Aula 04 
             * 
            */

            /* Aula 05 */

            IList<ContaComum> contas = ContasDoBanco();

            foreach (ContaComum conta in contas)
            {
                conta.somaInvestimento();

                Console.WriteLine("Novo Saldo: " + conta.Saldo());

            }

            Console.ReadLine();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();

            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));

            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
