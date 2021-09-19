namespace Pagamento.Entities {
    public class FuncionárioTerceirizado : Funcionário {
        public double GastoAdicional { get; set; }

        public FuncionárioTerceirizado(string nome, int horas, double valorPorHora, double gastoAdicional) : base(nome, horas, valorPorHora) {
            this.GastoAdicional = gastoAdicional;
        }

        public override double Pagamento() {
            return base.Pagamento() + this.GastoAdicional * 1.1;
        }
    }
}