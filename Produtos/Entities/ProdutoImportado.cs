using System.Globalization;

namespace Produtos.Entities {
    public class ProdutoImportado : Produto {
        public double TaxaDeAlfândega { get; set; }

        public ProdutoImportado(string nome, double preço, double taxaDeAlfândega) : base(nome, preço) {
            this.TaxaDeAlfândega = taxaDeAlfândega;
        }

        public double PreçoTotal() {
            return this.TaxaDeAlfândega + this.Preço;
        }

        public override string EtiquetaDePreço() {
            return $"{this.Nome} R${this.PreçoTotal().ToString("F2", CultureInfo.InvariantCulture)} (Taxa de alfândega: R${this.TaxaDeAlfândega.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}