using System;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAtribuicao {
        public static void Executar () {
            var num1 = 3; // Atribuido valor;
            num1 = 7;   // Reatribuindo valor;
            num1 += 10; // num1 = num1 + 10 ;
            num1 -= 3;  // num1 = num1 - 3 ;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            Console.WriteLine($"{a} {b}");

            a++;
            b--;
            Console.WriteLine($"{a} {b}");

            //cópia feita por valor e nao por referencia
        }
    }
}
