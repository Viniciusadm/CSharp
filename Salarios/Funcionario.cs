namespace Salarios {
    public class Funcionario {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salário { get; set; }

        public Funcionario(string nome, string email, double salário) {
            this.Nome = nome;
            this.Email = email;
            this.Salário = salário;
        }
    }
}