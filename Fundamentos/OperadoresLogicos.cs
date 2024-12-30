using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv de 50 polegadas? {0}",comprouTv50); // E lógico

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // OU lógico
            Console.WriteLine("comprou sorvete ?{0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // OU exclusivo (XOR)
            Console.WriteLine("comprou tv de 32 polegadas? {0}", comprouTv32);

            Console.WriteLine("mais saudavel? {0}", !comprouSorvete); // Negação de forma unária

        }
    }
}
