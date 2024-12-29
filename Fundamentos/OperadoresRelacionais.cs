using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar () {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota Inválida {0}", nota > 10.0);
            Console.WriteLine("Nota Inválida {0}", nota < 0.0);
        }
    }
}
