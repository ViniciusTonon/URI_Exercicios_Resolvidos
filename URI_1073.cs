// URI 1073: Quadrado de Pares.

// Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares,
// de 1 até N, inclusive N, se for o caso.
// Imprima o quadrado de cada um dos valores pares, de 1 até N.

using System;

namespace URI_1073
{
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i+=2) {
                int x = i * i;
                Console.WriteLine(i + "^2 = " + x);
            }
        }
    }
}
