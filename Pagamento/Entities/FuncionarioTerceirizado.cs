namespace Pagamento.Entities {
    public class Funcion├írioTerceirizado : Funcion├írio {
        public double GastoAdicional { get; set; }

        public Funcion├írioTerceirizado(string nome, int horas, double valorPorHora, double gastoAdicional) : base(nome, horas, valorPorHora) {
            this.GastoAdicional = gastoAdicional;
        }

        public override double Pagamento() {
            return base.Pagamento() + this.GastoAdicional * 1.1;
        }
    }
}