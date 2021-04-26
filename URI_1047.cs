// URI 1047: Tempo de Jogo com Minutos.

// Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo.
// A seguir calcule a duração do jogo.
// Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

using System;

namespace URI_1047 {
    class Program {
        static void Main(string[] args) {
            int hi, mi, hf, mf, ht, mt, Ti, Tf, T;

            string[] valores = Console.ReadLine().Split(' ');

            hi = int.Parse(valores[0]);
            mi = int.Parse(valores[1]);
            hf = int.Parse(valores[2]);
            mf = int.Parse(valores[3]);

            Ti = (hi * 60) + mi;
            Tf = (hf * 60) + mf;

            if (Ti >= Tf) {
                T = (24 * 60) - Ti + Tf;
            }
            else {
                T = Tf - Ti;
            }

            ht = T / 60;
            mt = T % 60;    

            Console.WriteLine("O JOGO DUROU " + ht + " HORA(S) E " + mt + " MINUTO(S)");
        }
    }
}
