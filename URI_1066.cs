// URI 1066: Pares, Ímpares, Positivos e Negativos.

// Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares,
// quantos valores digitados foram ímpares,quantos valores digitados foram 
// positivos e quantos valores digitados foram negativos.

using System;

namespace URI_1066 { 
    class Program {
        static void Main(string[] args) {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            int pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

            if (A % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (A > 0) {
                positivos++;
            }
            else if (A < 0) {
                negativos++;
            }

            if (B % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (B > 0) {
                positivos++;
            }
            else if (B < 0) {
                negativos++;
            }

            if (C % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (C > 0) {
                positivos++;
            }
            else if (C < 0) {
                negativos++;
            }

            if (D % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (D > 0) {
                positivos++;
            }
            else if (D < 0) {
                negativos++;
            }

            if (E % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (E > 0) {
                positivos++;
            }
            else if (E < 0) {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

        }
    }
}
