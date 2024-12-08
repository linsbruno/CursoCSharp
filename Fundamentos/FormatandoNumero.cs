using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // formata para arrendodamento de uma casa decimal
            Console.WriteLine(valor.ToString("C")); // formata para moeda corrente
            Console.WriteLine(valor.ToString("P")); // formata para percentual
            Console.WriteLine(valor.ToString("#.##")); // formata para arredondamento com duas casas decimais , poderia ser F2

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0",cultura)); // recebe o valor com nenhuma casa decimal e a cultura dos EUA

        }
    }
}
