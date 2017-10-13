using System;

namespace Solid
{
    public class ContaComum
    {
        private ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public double Saldo()
        {
            return this.manipulador.Saldo;
        }


        public void Deposita(double valor)
        {
            manipulador.Deposita(valor);
        }

        public void Saca(double valor)
        {
            manipulador.Saca(valor);
        }

        public void somaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }
    }
}