using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() { 
            // area da circunferencia
            // colocar o tipo da variavel 
            double raio = 4.5;
            // a palavra reservada "const" informa que é uma constante, inalteravel
            const double PI = 3.14;

            raio =  5.5;
            // PI = 3.1544;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            //Tipos Internos

            bool estaChovendo = true; // type true or false,booleano

            byte idade = 45;
            sbyte saldoDeGols = sbyte.MinValue;
            short salario = short.MaxValue;
            int menorVaorInt = int.MaxValue; //mais usado dos inteiros!
            uint populacao = 207_600_000;
            long valorLong = long.MaxValue;
            ulong valorULong = ulong.MaxValue;
            float valorFloat = 129.99f; // o float tem que ter o "F" no final
            double valorDouble = double.MaxValue;
            decimal valorDecimal = decimal.MaxValue;
            char valorChar = 'a'; // unica letra
            string valorString = "ouihasçdjaçsdgb";

        }
        

        }
    }

