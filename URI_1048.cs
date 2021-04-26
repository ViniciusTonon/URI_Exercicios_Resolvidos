// URI 1048: Aumento de Salário.

// A empresa ABC resolveu conceder um aumento de salários a seus funcionários de
// acordo com a tabela abaixo:

//               Salário              Percentual de Reajuste
//             0 - 400.00                        15%
//           400.01 - 800.00                     12%
//           800.01 - 1200.00                    10%
//          1200.01 - 2000.00                     7%
//           Acima de 2000.00                     4%

// Leia o salário do funcionário e calcule e mostre o novo salário, bem como o
// valor de reajuste ganho e o índice reajustado, em percentual.

using System;
using System.Globalization;

namespace URI_1048 {
    class Program {
        static void Main(string[] args) {
            double salario_atual, salario_novo, reajuste;
            int indice;

            salario_atual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario_atual <= 400.00) {
                indice = 15;
            }
            else if (salario_atual <= 800.00) {
                indice = 12;
            }
            else if (salario_atual <= 1200.00) {
                indice = 10;
            }
            else if (salario_atual <= 2000.00) {
                indice = 7;
            }
            else {
                indice = 4;
            }

            reajuste = salario_atual * ((double)indice / 100.00);
            salario_novo = salario_atual + reajuste;

            Console.WriteLine("Novo salario: " + salario_novo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + (int)indice + " %");
        }
    }
}
