using System.Globalization;

namespace banco {
    public class Conta {
        public double Saldo { get; private set; }
        public int NúmeroDaConta { get; private set; }
        public string NomeDoTitular { get; private set; }

        public Conta(int númeroDaConta, string nomeDoTitular) {
            this.NúmeroDaConta = númeroDaConta;
            this.NomeDoTitular = nomeDoTitular;
        }

        public Conta(int númeroDaConta, string nomeDoTitular, double saldo) : this(númeroDaConta, nomeDoTitular){
            this.Saldo = saldo;
        }

        public void DepositarDinheiro(double valor) {
            this.Saldo += valor;
        }

        public bool SacarDinheiro(double valor) {
            if (this.Saldo >= valor) {
                this.Saldo -= valor + 5;
                return true;
            } else {
                return false;
            }
        }

        override public string ToString() {
            string saldo = this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
            return $"Dados da conta:\nConta: {this.NúmeroDaConta}\nNome Do Titular: {this.NomeDoTitular}\nSaldo: R${saldo}\n";
        }

    }
}