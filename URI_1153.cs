// URI 1153: Fatorial Simples.

// Ler um valor N. Calcular e escrever seu respectivo fatorial.
// Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

using System;

namespace URI_1153
{
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= N; i++) {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
