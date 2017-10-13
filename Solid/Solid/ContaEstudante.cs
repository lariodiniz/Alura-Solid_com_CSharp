using System;

namespace Solid
{
    class ContaEstudante : ContaComum
    {
        private ManipuladorDeSaldo m;
        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            m = new ManipuladorDeSaldo();
        }
        public void Deposita(double valor)
        {
            m.Deposita(valor);
            this.Milhas += (int)valor;
        }

        public double Saldo()
        {
            return this.m.Saldo;
        }
    }
}