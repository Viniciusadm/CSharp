using System.Globalization;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pagamento básico: {this.PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"{this.Taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Pagamento total: {this.PagamentoTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}