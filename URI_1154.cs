// URI 1054: Idades.

// Faça um algoritmo para ler um número indeterminado de dados, contendo cada um,
// a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém o
// valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

using System;
using System.Globalization;

namespace URI_1154 {
    class Program {
        static void Main(string[] args) {

            int idade, soma, cont; 
            double media;

            idade = int.Parse(Console.ReadLine());

            soma = 0;
            cont = 0;

            while (idade > 0) {
                cont++;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
