// URI 1113: Crescente e Decrescente.

// Leia uma quantidade indeterminada de duplas de valores inteiros X e Y.
// Escreva para cada X e Y uma mensagem que indique se estes valores foram
// digitados em ordem crescente ou decrescente.

using System;

namespace URI_1113 {
    class Program {
        static void Main(string[] args) {

            int X, Y;
            string[] valores = Console.ReadLine().Split(' ');

            X = int.Parse(valores[0]);
            Y = int.Parse(valores[1]);

            while (X != Y) {
                if (X > Y) {
                    Console.WriteLine("Decrescente");
                }
                else {
                    Console.WriteLine("Crescente");
                }

                string[] valores1 = Console.ReadLine().Split(' ');
                X = int.Parse(valores1[0]);
                Y = int.Parse(valores1[1]);
            }
        }
    }
}
