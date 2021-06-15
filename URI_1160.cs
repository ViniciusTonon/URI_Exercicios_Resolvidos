// URI 1160: Crescimento Populacional.

// Mariazinha quer resolver um problema interessante. Dadas as informações de população e a taxa
// de crescimento de duas cidades quaisquer (A e B), ela gostaria de saber quantos anos levará
// para que a cidade menor (sempre é a cidade A) ultrapasse a cidade B em população. Claro que ela
// quer saber apenas para as cidades cuja taxa de crescimento da cidade A é maior do que a taxa de
// crescimento da cidade B, portanto, previamente já separou para você apenas os casos de teste que
// tem a taxa de crescimento maior para a cidade A. Sua tarefa é construir um programa que apresente
// o tempo em anos para cada caso de teste.
// Porém, em alguns casos o tempo pode ser muito grande, e Mariazinha não se interessa em saber exatamente 
// o tempo para estes casos. Basta que você informe, nesta situação, a mensagem "Mais de 1 seculo.".

using System;
using System.Globalization;

namespace URI_1160 {
    class Program {
        static void Main(string[] args) {

            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int PA = int.Parse(valores[0]);
                int PB = int.Parse(valores[1]);
                double G1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double G2 = double.Parse(valores[3], CultureInfo.InvariantCulture);

                int TA = PA;
                int TB = PB;
                int tempo = 0;

                while (TA <= TB) {
                    TA = (int)(TA * (G1 / 100.00)) + TA;
                    TB = (int)(TB * (G2 / 100.00)) + TB;
                    tempo++;
                }

                if (tempo > 100) {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else {
                    Console.WriteLine(tempo + " anos.");
                }
            }
        }
    }
}
