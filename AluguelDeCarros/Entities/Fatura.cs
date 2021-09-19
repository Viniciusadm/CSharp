using System.Globalization;

namespace AluguelDeCarros.Entities {
    public class Fatura {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBase, double taxa) {
            this.PagamentoBase = pagamentoBase;
            this.Taxa = taxa;
        }

        public double PagamentoTotal() {
            return this.PagamentoBase + this.Taxa;
        }

        override public string ToString() {
            return $"Pagamento básico: {this.PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)}\n{this.Taxa.ToString("F2", CultureInfo.InvariantCulture)}\nPagamento total: {this.PagamentoTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}