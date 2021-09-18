using System.Collections.Generic;
using ContratoDeTrabalho.Entities.Enums;

namespace ContratoDeTrabalho.Entities {
    public class Trabalhador {
        public string Nome { get; set; }
        public NívelDoTrabalhador Nível { get; set; }
        public double SalárioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoDeHoras> Contratos { get; set; } = new List<ContratoDeHoras>();

        public Trabalhador() {

        }

        public Trabalhador(string nome, NívelDoTrabalhador nível, double salário, Departamento departamento) {
            this.Nome = nome;
            this.Nível = nível;
            this.SalárioBase = salário;
            this.Departamento = departamento;
        }

        public void AdicionarContrato(ContratoDeHoras contrato) {
            this.Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoDeHoras contrato) {
            this.Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mês) {
            double sum = this.SalárioBase;
            foreach (ContratoDeHoras contrato in this.Contratos) {
                if (contrato.Data.Year == ano && contrato.Data.Month == mês) {
                    sum += contrato.ValorTotal();
                }
            }
            return sum;
        }
    }
}