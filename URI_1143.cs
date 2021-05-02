// URI 1143: Quadrado e ao Cubo.

// Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a 
// quantidade de linhas de saída que serão apresentadas na execução do programa.
// Imprima a saída conforme o exemplo fornecido.
// Entrada : 5
// 1 1 1
// 2 4 8
// 3 9 27
// 4 16 64
// 5 25 125

using System;

namespace URI_1143 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
            }
        }
    }
}
