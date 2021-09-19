namespace Salario {
    public class Funcionário {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salário { get; private set; }

        public Funcionário(int id, string nome, double salário) {
            this.ID = id;
            this.Nome = nome;
            this.Salário = salário;
        }

        public void AumentarSalário(double porcentagem) {
            double valorPorcentagem = (porcentagem * this.Salário) / 100;
            this.Salário += valorPorcentagem;
        }

        public override string ToString() {
            return $"ID: {this.ID}, Nome: {this.Nome}, Salário: {this.Salário}";
        }
    }
}