// URI 1151: Fibonacci Fácil.

// A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série
// de Fibonacci. Nessa sequência, cada número, depois dos 2 primeiros, é igual à
// soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e
// mostre os N primeiros números dessa série.

using System;

namespace URI_1151 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < N; i++) {
                if (i == N - 1) {
                    Console.WriteLine(a);
                }
                else {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }
        }
    }
}