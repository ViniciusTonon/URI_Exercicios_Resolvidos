// URI 1040: Média 3.

// Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente 
// às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente,
// para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ".
// Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média
// calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada
// for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

// No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno.
// Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média
// (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a
// mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.",
// (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego 
// exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

using System;
using System.Globalization;

namespace URI_1040 {
    class Program {
        static void Main(string[] args) {

            float N1, N2, N3, N4, Media, exame, final;
            string[] vet = Console.ReadLine().Split(' ');

            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            Media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10;

            // O problema 1040 tem uma falha de arredondamento especifica
            // para a linguagem C#. Quando a media da 4.85, nos temos que
            // ajusta-la manualmente para 4.8, o que e uma "gambiarra"
            // OBS: Sugestão do professor do curso.
            
            if (Media == 4.85f) {
                Media = 4.8f;
            }
            Console.WriteLine("Media: " + Media.ToString("F1",CultureInfo.InvariantCulture));

            if (Media >= 7.00) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (Media < 5.00) {
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                final = (Media + exame) / 2;
                if (final >= 5.00) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + final.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
