using Formas.Entities.Enums;

namespace Formas.Entities {
    public class Retângulo : Forma {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retângulo(Cor cor, double altura, double largura) : base(cor) {
            this.Largura = largura;
            this.Altura = altura;
        }

        public override double Área() {
            return this.Altura * this.Largura;
        }
    }
}