// URI 1044: Múltiplos.

//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos"
// ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

using System;

namespace URI_1044 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

           int A = int.Parse(vet[0]);
           int B = int.Parse(vet[1]);

            if ((A % B == 0) || (B % A == 0)) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
