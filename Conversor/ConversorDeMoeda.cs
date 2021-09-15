using System.Globalization;

namespace Conversor {
    public class ConversorDeMoeda {
        public static string ValorASerPago(double cotaçãoDoDolar, double dolares) {
            double valorLíquido = cotaçãoDoDolar * dolares;
            double porcentagem = (valorLíquido * 6) / 100;
            return (valorLíquido + porcentagem).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}