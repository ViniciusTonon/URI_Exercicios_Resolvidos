// URI 1165: Número Primo.

// Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo. 
// Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.
// A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100),
// indicando o número de casos de teste da entrada. Cada uma das N linhas seguintes contém um valor inteiro
// X (1 < X ≤ 107), que pode ser ou não, um número primo.
// Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”, de acordo com a
// especificação fornecida.


using System;

namespace URI_1165 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                int X = int.Parse(Console.ReadLine());
                int aux = 0;
                for (int j = 2; j <= X; j++) {                    
                    if (X % j == 0) {
                        aux = aux + 1;
                    }                    
                }
                if (aux > 1) {
                    Console.WriteLine(X + " nao eh primo");
                }
                else {
                    Console.WriteLine(X + " eh primo");
                }
            }
        }
    }
}
