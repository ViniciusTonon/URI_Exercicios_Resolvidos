// URI 1071: Soma de Impares Consecutivos I.

// Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos
// números impares entre eles.


using System;

namespace URI_1071 {
    class Program {
        static void Main(string[] args) {

            int X, Y, Soma, min, max;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y) {
                max = Y;
                min = X;
            }
            else {
                max = X;
                min = Y;
            }

            Soma = 0;

            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    Soma += i;
                }
            }
            Console.WriteLine(Soma);
        }
    }
}
