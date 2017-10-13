namespace Solid
{
    public class Pagamento
    {
        private double valor;
        private MeioDePagamento Forma;

        public Pagamento(double valor, MeioDePagamento forma)
        {
            this.valor = valor;
            this.Forma = forma;
        }

        public double Valor { get; internal set; }
    }
}