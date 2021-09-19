using System.Globalization;
using Formas.Entities.Enums;

namespace Formas.Entities {
    public abstract class Forma {
        public Cor Cor { get; set; }
        
        public Forma(Cor cor) {
            this.Cor = cor;
        }

        public abstract double Área();

        public override string ToString() {
            return $"{this.Cor} - {this.Área().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}