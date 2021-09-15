using System.Globalization;

namespace Funcionario {
    public class Funcionário {
        private string Nome;
        private double SalárioBruto;
        private double Imposto;

        public Funcionário(string Nome, double salárioBruto, double Imposto) {
            this.Nome = Nome;
            this.SalárioBruto = salárioBruto;
            this.Imposto = Imposto;
        }

        public double SalárioLiquido() {
            double imposto = (this.Imposto * this.SalárioBruto) / 100;
            return this.SalárioBruto - imposto;
        }

        public void AumentarSalário(double porcentagem) {
            double aumento = (this.SalárioBruto * porcentagem) / 100;
            this.SalárioBruto += aumento;
        }

        public override string ToString() {
            string salárioFormatado = this.SalárioLiquido().ToString(CultureInfo.InvariantCulture);
            return $"{this.Nome}, R${salárioFormatado}";
        }
    }
}