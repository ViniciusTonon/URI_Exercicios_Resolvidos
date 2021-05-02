// URI 1075: Resto 2.

// Leia um valor inteiro N. Apresente todos os números entre
// 1 e 10000 que divididos por N dão resto igual a 2.

using System;

namespace URI_1075 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
                if (i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
