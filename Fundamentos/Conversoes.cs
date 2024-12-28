using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;     //conversão implicita 
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // conversão explicita, CASTING
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);  //passa uma string para numero, quando possivel
            Console.WriteLine("idade inserida : {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // tambem converte string em inteiro
            Console.WriteLine("resultado : {0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero; 
            int.TryParse(palavra, out numero); //tenta passar o string para número
            Console.WriteLine("resultado : {0}", numero);

            Console.WriteLine("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("o resultado 2: {0}" , numero2);

             

        }
    }
}
