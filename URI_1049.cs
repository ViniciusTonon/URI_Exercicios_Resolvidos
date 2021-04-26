// URI 1049: Animal.

// Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo
// o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais
// seguintes foi escolhido, através das três palavras fornecidas.

// vertebrado - ave - carnivoro - aguia
// vertebrado - ave - onivoro - pomba
// vertebrado - mamifero - onivoro - homem
// vertebrado - mamifero - herbivoro - vaca
// invertebrado - inseto - hematofago - pulga
// invertebrado - inseto - herbivoro - lagarta
// invertebrado - anelideo - hematofago - sanguessuga
// invertebrado - anelideo - onivoro - minhoca

using System;

namespace URI_1049 {
    class Program {
        static void Main(string[] args) {
            
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            if (A == "vertebrado") {
                if (B == "ave") {
                    if (C == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else {
                        Console.WriteLine("pomba");
                    }
                }
                else {
                    if (C == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else {
                if (B == "inseto") {
                    if (C == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else {
                        Console.WriteLine("lagarta");
                    }
                }
                else {
                    if (C == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}


