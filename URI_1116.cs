// URI 1116: Dividindo X por Y.

// Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não
// for possível mostre a mensagem “divisao impossivel” para os valores em questão.
// A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão
// lidos em seguida.

using System;
using System.Globalization;

namespace URI_1116
{
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
