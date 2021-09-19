using System;
using Formas.Entities.Enums;

namespace Formas.Entities {
    public class Círculo : Forma {
        public double Raio { get; set; }
        
        public Círculo(Cor cor, double raio) : base(cor) {
            this.Raio = raio;
        }

        public override double Área() {
            return Math.PI * Math.Pow(this.Raio, 2);
        }
    }
}