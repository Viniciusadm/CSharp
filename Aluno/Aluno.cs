using System.Globalization;

namespace aluno {
    public class Aluno {
        private string Nome;
        private double Nota1;
        private double Nota2;
        private double Nota3;

        public Aluno(string Nome, double Nota1, double Nota2, double Nota3) {
            this.Nome = Nome;
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
            this.Nota3 = Nota3;
        }

        private double NotaFinal() {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        private bool Aprovação() {
            if (this.NotaFinal() >= 60) return true;
            else return false;
        }

        public override string ToString() {
            string notaFinal = this.NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
            if (Aprovação()) {
                return $"Nota Final: {notaFinal}\nAprovado";
            }
            else {
                string falta = (60 - this.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture);
                return $"Nota Final: {notaFinal}\nReprovado\nFaltaram: {falta} pontos";
            }
        }
    }
}