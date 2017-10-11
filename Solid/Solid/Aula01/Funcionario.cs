namespace Solid
{
    public class Funcionario
    {
        public double SalarioBase { get; internal set; }
        internal Cargo Cargo { get; set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public double CalculaSalario()
        {
            return this.Cargo.Regra.Calcula(this);
        }
    }
}