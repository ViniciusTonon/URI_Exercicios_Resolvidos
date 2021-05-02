// URI 1099: Soma de Ímpares Consecutivos II.

// Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.
// Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma
// de todos os ímpares existentes entre X e Y.

using System;

namespace URI_1099 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (X > Y) {
                    int aux = X;
                    X = Y;
                    Y = aux;
                }
                int soma = 0;
                for (int z = X + 1; z < Y; z++) {                    
                    if (z % 2 != 0) {
                        soma = soma + z;                       
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
