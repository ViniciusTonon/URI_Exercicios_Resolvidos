// URI 1080: Maior e Posição.

// Leia 100 valores inteiros. Apresente então o maior valor lido e a
// posição dentre os 100 valores lidos.


using System;

namespace URI_1080 {
    class Program {
        static void Main(string[] args) {

            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++) {
                int N = int.Parse(Console.ReadLine());
                if (N > maior) {
                    maior = N;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
