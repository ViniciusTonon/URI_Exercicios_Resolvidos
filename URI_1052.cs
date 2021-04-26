// URI 1052:

// Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor,
// deve ser apresentado como resposta o mês do ano por extenso, em inglês,
// com a primeira letra maiúscula.

using System;

namespace URI_1052 {
    class Program {
        static void Main(string[] args) {
            int Mes = int.Parse(Console.ReadLine());

            if (Mes == 1) {
                Console.WriteLine("January");
            }
            else if (Mes == 2) {
                Console.WriteLine("February");
            }
            else if (Mes == 3) {
                Console.WriteLine("March");
            }
            else if (Mes == 4) {
                Console.WriteLine("April");
            }
            else if (Mes == 5) {
                Console.WriteLine("May");
            }
            else if (Mes == 6) {
                Console.WriteLine("June");
            }
            else if (Mes == 7) {
                Console.WriteLine("July");
            }
            else if (Mes == 8) {
                Console.WriteLine("August");
            }
            else if (Mes == 9) {
                Console.WriteLine("September");
            }
            else if (Mes == 10) {
                Console.WriteLine("October");
            }
            else if (Mes == 11) {
                Console.WriteLine("November");
            }
            else if (Mes == 12) {
                Console.WriteLine("December");
            }
        }
    }
}
