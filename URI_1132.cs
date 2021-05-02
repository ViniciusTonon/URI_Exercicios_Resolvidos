// URI 1132: Múltiplos de 13.

// Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma
// dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

using System;

namespace URI_1132 {
    class Program {
        static void Main(string[] args) {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int menor = A;
            int maior = B;

            if (A > B) {
                menor = B;
                maior = A;
            }            
            
            int soma = 0;

            for (int i = menor; i <= maior; i++) {
                if ((double)i % 13 != 0.0) {
                    soma += i; 
                }
            }
            Console.WriteLine(soma);
        }
    }
}
