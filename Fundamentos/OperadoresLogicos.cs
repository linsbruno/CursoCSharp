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
            Console.WriteLine("Comprou a tv de 50 polegadas? {0}",comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("comprou sorvete ?{0}", comprouSorvete);

            var comrpouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("comprou tv de 32 polegadas? {0}", comrpouTv32);

        }
    }
}
