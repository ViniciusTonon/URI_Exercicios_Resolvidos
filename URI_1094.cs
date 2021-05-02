// URI 1094: Experiências.

// Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar 
// os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias
// foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.
// Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações,
// ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de 
// cobaias utilizadas em cada experimento. 
// A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso 
// de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere
// Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho)
// Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação
// ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.


using System;
using System.Globalization;

namespace URI_1094 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;
         
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');

                int Quantia = int.Parse(valores[0]);
                int Tipo = char.Parse(valores[1]);

                if (Tipo == 'C') {
                    coelhos += Quantia;
                }
                else if (Tipo == 'R') {
                    ratos += Quantia;
                }
                else if (Tipo == 'S') {
                    sapos += Quantia;
                }
            }
            int total = coelhos + ratos + sapos;
            double Pc = (double) coelhos / total * 100.00;
            double Pr = (double) ratos / total * 100.00;
            double Ps = (double) sapos / total * 100.00;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + Pc.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + Pr.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + Ps.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
