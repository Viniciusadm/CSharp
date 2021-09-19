using System.Globalization;

namespace Imposto.Entities {
    public abstract class TaxaDeImposto {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; }

        public TaxaDeImposto(string nome, double rendaAnual) {
            this.Nome = nome;
            this.RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

        public override string ToString() {
            return $"{this.Nome}: {this.Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}