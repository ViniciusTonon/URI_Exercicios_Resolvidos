// URI 1115: Quadrante.

// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada
// de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence.
// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA
// (nesta situação sem escrever mensagem alguma).

using System;

namespace URI_1115 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 || y != 0) {
                if (x > 0 && y >0) {
                    Console.WriteLine("primeiro");
                }
                if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                if (x > 0 && y < 0) {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
