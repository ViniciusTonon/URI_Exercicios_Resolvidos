// URI 1061: Tempo de um Evento.
// Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril,
// iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o
// evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.
// Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho
// a calcular a duração deste evento.

using System;

namespace URI_1061 {
    class Program     {
        static void Main(string[] args) {

            int h1, m1, s1, h2, m2, s2, d1, d2, H, M, S, D, inicio, fim, duracao, resto;

            string[] valores = Console.ReadLine().Split(' ');
            d1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            h1 = int.Parse(valores[0]);
            m1 = int.Parse(valores[2]);
            s1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            d2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            h2 = int.Parse(valores[0]);
            m2 = int.Parse(valores[2]);
            s2 = int.Parse(valores[4]);

            inicio = (d1 * 24 * 60 * 60) + (h1 * 60 * 60) + (m1 * 60) + s1;
            fim = (d2 * 24 * 60 * 60) + (h2 * 60 * 60) + (m2 * 60) + s2;
            duracao = fim - inicio;

            D = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            H = resto / (60 * 60);
            resto = resto % (60 * 60);
            M = resto / 60;
            S = resto % 60;

            Console.WriteLine(D + " dia(s)");
            Console.WriteLine(H + " hora(s)");
            Console.WriteLine(M + " minuto(s)");
            Console.WriteLine(S + " segundo(s)");

        }
    }
}
