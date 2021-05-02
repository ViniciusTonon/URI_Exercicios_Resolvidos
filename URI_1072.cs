// URI 1072: Intervalo 2.

// Leia um valor inteiro N. Este valor será a quantidade de valores
// inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20]
// e quantos estão fora do intervalo, mostrando essas informações.

using System;

namespace URI_1072 {
    class Program {
        static void Main(string[] args) {

            int N, i, X, In, Out;

           N = int.Parse(Console.ReadLine());

            In = 0;
            Out = 0;

            for (i = 0; i < N; i++) {
                 X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20) {
                    In++;
                }
                else {
                    Out++;
                }
            }
            Console.WriteLine(In + " in");
            Console.WriteLine(Out + " out");                       
        }
    }
}
