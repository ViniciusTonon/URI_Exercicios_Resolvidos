// URI 1079: Médias Ponderadas.

// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
// Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
// Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o
// primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

using System;
using System.Globalization;

namespace URI_1079 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
