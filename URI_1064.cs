// URI 1064: Positivos e Média.

// Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos.
// Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados,
// com um dígito após o ponto decimal.

using System;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, media, A, B, C, D, E, F;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int positivos;

            positivos = 0;
            soma = 0;

            if (A > 0.0) {
                positivos += 1;
                soma += A;
            }
            if (B > 0.0) {
                positivos += 1;
                soma += B;
            }
            if (C > 0.0) {
                positivos += 1;
                soma += C;
            }
            if (D > 0.0) {
                positivos += 1;
                soma += D;
            }
            if (E > 0.0) {
                positivos += 1;
                soma += E;
            }
            if (F > 0.0) {
                positivos += 1;
                soma += F;
            }
            
            media = soma / positivos;

            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
