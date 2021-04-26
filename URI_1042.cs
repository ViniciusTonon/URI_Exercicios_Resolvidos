// URI 1042: Sort Simples.

//Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores
//em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

using System;

namespace URI_1042 {
    class Program {
        static void Main(string[] args) {

            int A, B, C, menor, meio, maior;
            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            if (A < B && A < C) {
                menor = A;
                if (B < C) {
                    meio = B;
                    maior = C;
                }
                else {
                    meio = C;
                    maior = B;
                }
            }
            else if (B < C) {
                menor = B;
                if (A < C) {
                    meio = A;
                    maior = C;
                }
                else {
                    meio = C;
                    maior = A; ;
                }
            }
            else {
                menor = C;
                if (B < A) {
                    meio = B;
                    maior = A;
                }
                else {
                    meio = A;
                    maior = B;
                }
            }
            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
