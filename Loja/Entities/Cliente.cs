using System;

namespace Loja.Entities {
    public class Cliente {
        public string NomeDoCliente { get; private set; }
        public string Email { get; private set; }
        public DateTime DataDeAniversário { get; private set; } 

        public Cliente(string nomeDoCliente, string email, DateTime dataDeAniversário) {
            this.NomeDoCliente = nomeDoCliente;
            this.Email = email;
            this.DataDeAniversário = dataDeAniversário;
        }

        public override string ToString() {
            string dataDeAniversário = this.DataDeAniversário.ToString("dd/MM/yyyy)");
            return $"{this.NomeDoCliente}  ({dataDeAniversário}) - {this.Email}";
        }
    }
}