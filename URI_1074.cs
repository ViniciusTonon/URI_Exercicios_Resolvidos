/*
URI 1073: Pares e Ímpares.

Leia um valor inteiro N. Este valor será a quantidade de valores que serão
lidos em seguida. Para cada valor lido, mostre uma mensagem em inglês dizendo
se este valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo
(NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta
seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir
apenas NULL.
*/


using System;

namespace URI_1074 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0 && x > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x % 2 != 0 && x > 0) {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x % 2 == 0 && x < 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (x % 2 != 0 && x < 0) {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
