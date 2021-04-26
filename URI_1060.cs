// URI 1060: Números Positivos.

// Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos
// (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

using System;
using System.Globalization;

namespace URI_1060 {
    class Program {
        static void Main(string[] args) {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int positivos = 0;

            if (A > 0.0) {
                positivos = positivos + 1;
            }
            if (B > 0.0) {
                positivos = positivos + 1;
            }
            if (C > 0.0) {
                positivos = positivos + 1;
            }
            if (D > 0.0) {
                positivos = positivos + 1;
            }
            if (E > 0.0) {
                positivos = positivos + 1;
            }
            if (F > 0.0) {
                positivos = positivos + 1;
            }
            Console.WriteLine(positivos + " valores positivos");
        }
    }
}
