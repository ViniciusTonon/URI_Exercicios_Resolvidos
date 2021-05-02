// URI 1133: Resto da Divisão.

// Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre
// eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.

using System;

namespace URI_1133 {
    class Program {
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int menor = X;
            int maior = Y;

            if (X > Y) {
                maior = X;
                menor = Y;
            }

            for (int i = menor + 1; i < maior; i++) {
                if (i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
