// URI 1042: PUM.

// Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de
// saída que serão apresentadas na execução do programa.
// Imprima a saída conforme o exemplo fornecido.
// Entrada: 7
// 1 2 3 PUM
// 5 6 7 PUM
// 9 10 11 PUM
// 13 14 15 PUM
// 17 18 19 PUM
// 21 22 23 PUM
// 25 26 27 PUM


using System;

namespace URI_1142 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int A = 1;
           
            for (int i = 1; i <= N; i++) {
                int B = A + 1;
                int C = A + 2;
                Console.WriteLine(A + " " + B + " " + C + " PUM");
                A = A + 4;
            }
        }
    }
}
