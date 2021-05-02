// URI 1145: Sequência Lógica 2.

// Escreva um programa que leia dois valores X e Y. A seguir, mostre uma
// sequência de 1 até Y, passando para a próxima linha a cada X números.
// Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em
// branco entre cada número, conforme exemplo abaixo. Não deve haver espaço
// em branco após o último valor da linha.
// Entrada: 3 99
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12
// ...
// 97 98 99

using System;

namespace URI_1145 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            for (int i = 1; i <= Y; i++) {
                if (i % X != 0) {
                    Console.Write(i + " ");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
