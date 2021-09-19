namespace Aluguel {
    public class Estudante {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Estudante(string nome, string email) {
            this.Nome = nome;
            this.Email = email;
        }
    }
}