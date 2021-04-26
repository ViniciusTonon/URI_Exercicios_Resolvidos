//URI 1045: Tipos de Triângulos.

// Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que 
// o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes 
// três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
// se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
// se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
// se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
// se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
// se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
// se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

using System;
using System.Globalization;

namespace URI_1045 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
           
            double A, B, C;
            if (n1 > n2 && n1 > n3) {
                A = n1;
                if (n2 > n3) {
                    B = n2;
                    C = n3;
                }
                else {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3) {
                A = n2;
                if (n1 > n3) {
                    B = n1;
                    C = n3;
                }
                else {
                    B = n3;
                    C = n1;
                }
            }
            else {
                A = n3;
                if (n1 > n2) {
                    B = n1;
                    C = n2;
                }
                else {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (A * A == B * B + C * C) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
