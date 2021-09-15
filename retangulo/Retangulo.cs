using System;

namespace retangulo {
    public class Retangulo {
        private double Largura;
        private double Altura;
        public Retangulo(double largura, double altura) {
            this.Largura = largura;
            this.Altura = altura;
        }

        public double Área() {
            return this.Largura * this.Altura;
        }

        public double Perímetro() {
            return Math.Pow(this.Largura, 2) + Math.Pow(this.Altura, 2);
        }

        public double Diagonal() {
            return Math.Sqrt(this.Perímetro());
        }
    }
}