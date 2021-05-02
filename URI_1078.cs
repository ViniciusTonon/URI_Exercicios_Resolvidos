// URI 1078: Tabuada.

// Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
// 1 x N = N      2 x N = 2N        ...       10 x N = 10N

using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int R = N * i;
                Console.WriteLine(i + " x " + N + " = " + R);
            }
        }
    }
}
