// URI 1158: Soma de Ímpares Consecutivos III.

// Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso
// de teste consiste de dois inteiros X e Y. Você deve apresentar a soma de Y ímpares consecutivos
// a partir de X inclusive o próprio X se ele for ímpar. Por exemplo:
// para a entrada 4 5, a saída deve ser 45, que é equivalente à: 5 + 7 + 9 + 11 + 13
// para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13

using System;

namespace URI_1158 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= N; i++) {
                string[] valores = Console.ReadLine().Split(' ');                
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (X % 2 == 0) {
                    X++;
                }
                int soma = 0;
                for (int j = 1; j <= Y; j++) {
                    soma = soma + X;
                    X = X + 2;
                }
                Console.WriteLine(soma);                
            }            
        }
    }
}
