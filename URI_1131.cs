//URI 1131: Grenais.

// A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística
// do resultado de vários GRENAIS. Escreva um programa para ler o número de gols marcados pelo Inter
// e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar
// uma resposta. Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número
// de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

// Quantos GRENAIS fizeram parte da estatística.
// O número de vitórias do Inter.
// O número de vitórias do Grêmio.
// O número de Empates.
// Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor",
// caso termine empatado).

using System;

namespace URI_1131 {
    class Program {
        static void Main(string[] args) {

            int Empate = 0;
            int VI = 0;
            int VG = 0;
            int cont = 0;
            int novo = 1;

            while (novo == 1) {
                string[] placar = Console.ReadLine().Split(' ');

                int inter = int.Parse(placar[0]);
                int gremio = int.Parse(placar[1]);

                cont++;
                if (inter > gremio) {
                    VI++;
                }
                else if (gremio > inter) {
                    VG++;
                }
                else {
                    Empate++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + VI);
            Console.WriteLine("Gremio:" + VG);
            Console.WriteLine("Empates:" + Empate);

            if (VI > VG) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (VI < VG) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
