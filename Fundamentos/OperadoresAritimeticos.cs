﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritimeticos {
        public static void Executar() {
            // Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("o preço final é {0}", totalComDesconto);

            //IMC
            //
            double peso = 130.2;
            double altura = 1.84;
            double imc = peso / Math.Pow(altura,2);

            Console.WriteLine($"IMC é {imc}");

            //numero par e impar

            int par = 24;
            int impar = 55;
            Console.WriteLine(" {0} /2 tem o resto {1}" , par , par % 2);
            Console.WriteLine(" {0} /2 tem o resto {1}" , impar , impar % 2);

        }
    }
}
