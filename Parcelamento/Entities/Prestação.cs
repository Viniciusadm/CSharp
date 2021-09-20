using System;
using System.Globalization;

namespace Parcelamento.Entities {
    public class Prestação {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Prestação(DateTime dataDeVencimento, double valor) {
            this.DataDeVencimento = dataDeVencimento;
            this.Valor = valor;
        }

        public override string ToString() {
            return $"{this.DataDeVencimento.ToString("dd/MM/yyyy")} - {this.Valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}