// URI 1101: Sequência de Números e Soma.

// Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos
// valores for menor ou igual a zero). Para cada par lido, mostre a sequência do menor
// até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

using System;

namespace URI_1101 {
    class Program {
        static void Main(string[] args) {

            int M, N;
            string[] valores1 = Console.ReadLine().Split(' ');
            M = int.Parse(valores1[0]);
            N = int.Parse(valores1[1]);

            while (M > 0 && N > 0) {
                if (M > N) {
                    int aux = M;
                    M = N;
                    N = aux;
                }
                int soma = 0;
                for (int i = M; i <= N; i++) {
                    Console.Write(i + " ");
                    soma = soma + i;
                }
                Console.WriteLine("Sum=" + soma);
                string[] valores = Console.ReadLine().Split(' ');
                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);
            }
        }
    }
}
