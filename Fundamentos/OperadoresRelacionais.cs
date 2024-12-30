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

            Console.WriteLine("Nota Inválida {0}", nota > 10.0); //Operador lógico "Maior Que"
            Console.WriteLine("Nota Inválida {0}", nota < 0.0); //Operador lógico "Menor Que"
            Console.WriteLine("Perfeito {0}", nota == 10.0); //Operador lógico "Igual a"
            Console.WriteLine("Tem como melhorar {0}", nota != 10.0); //Operador lógico "Diferente de"
            Console.WriteLine("Passou pordia  {0}", nota >= 7.0); //Operador lógico "Maior ou Igual"
            Console.WriteLine("Recuperação  {0}", nota < 7.0); //Operador lógico "Menor Que"
            Console.WriteLine("Reprovado  {0}", nota <= 3.0); //Operador lógico "Menor ou Igual a"

            // no console, todos os resultados serão um booleano ( True or False )
        }
    }
}
