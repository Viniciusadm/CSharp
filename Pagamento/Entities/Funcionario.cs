using System.Globalization;

namespace Pagamento.Entities {
    public class Funcionário {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionário(string nome, int horas, double valorPorHora) {
            this.Nome = nome;
            this.Horas = horas;
            this.ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() {
            return this.ValorPorHora * this.Horas;
        }

        public override string ToString() {
            return $"{this.Nome} - R${this.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}