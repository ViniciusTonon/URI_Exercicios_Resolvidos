// URI 1156: Sequência SII.

// Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
// S = 1 + 3/2 + 5/4 + 7/8 + ... +39/?

using System;
using System.Globalization;

namespace URI_1156 {
    class Program {
        static void Main(string[] args) {

            double x = 1.0;
            double soma = 0.0;

            for (int i = 1; i <= 39; i += 2) {
                soma = (double) soma + (i / x);
                x = x * 2.0;
            }
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
