// URI 1070: Seis números ímpares.

// Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos 
// a partir de X, um valor por linha, inclusive o X ser for o caso.

using System;

namespace URI_1070 {
    class Program {
        static void Main(string[] args) {

            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0) {
                Console.WriteLine(X + 1);
                Console.WriteLine(X + 3);
                Console.WriteLine(X + 5);
                Console.WriteLine(X + 7);
                Console.WriteLine(X + 9);
                Console.WriteLine(X + 11);
            }
            else {
                Console.WriteLine(X);
                Console.WriteLine(X + 2);
                Console.WriteLine(X + 4);
                Console.WriteLine(X + 6);
                Console.WriteLine(X + 8);
                Console.WriteLine(X + 10);
            }
        }
    }
}
