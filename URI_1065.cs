// URI 1065: Pares entre cinco números. 

//Faça um programa que leia 5 valores inteiros. Conte quantos destes valores
//digitados são pares e mostre esta informação.

using System;

namespace URI_1065 {
    class Program {
        static void Main(string[] args) {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            int pares;

            pares = 0;

            if (A % 2 == 0) {
                pares += 1;
            }
            if (B % 2 == 0) {
                pares += 1;
            }
            if (C % 2 == 0) {
                pares += 1;
            }
            if (D % 2 == 0) {
                pares += 1;
            }
            if (E % 2 == 0) {
                pares += 1;
            }

            Console.WriteLine(pares + " valores pares");
        }
    }
}
