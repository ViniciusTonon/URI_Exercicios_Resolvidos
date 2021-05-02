//URI 1067: Números Ímpares.

// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,
// um valor por linha, inclusive o X, se for o caso.

using System;

namespace URI_1067 {
    class Program {
        static void Main(string[] args) {

            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}
