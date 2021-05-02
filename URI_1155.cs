// URI 1155: Sequência S.

// Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
// S = 1 + 1 / 2 + 1 / 3 + … +1 / 100

using System;
using System.Globalization;

namespace uri1155 {
    class Program {
        static void Main(string[] args) {

            double soma = 0;

            for (int i = 1; i <= 100; i++) {
                soma = (double)soma + (1.00 / i);
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}