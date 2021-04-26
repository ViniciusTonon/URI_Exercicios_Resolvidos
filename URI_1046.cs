// URI 1046: Tempo de Jogo.

// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
// sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração
// mínima de 1 hora e máxima de 24 horas.

using System;

namespace URI_1046 {
    class Program {
        static void Main(string[] args) {
            int inicio, fim, duracao;

            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio >= fim) {
                duracao = 24 - inicio + fim;
            }
            else {
                duracao = fim - inicio;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
