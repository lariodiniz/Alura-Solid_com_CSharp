using System;

namespace Solid
{
    public class Compra
    {
        public double Valor { get; internal set; }
        public String Cidade { get; internal set; }

        public Compra(int valor, String cidade)
        {
            this.Valor = valor;
            this.Cidade = cidade;
        }     
    }
}