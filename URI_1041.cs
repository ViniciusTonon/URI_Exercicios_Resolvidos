// URI 1041: Coordenadas de um ponto.

//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto,
//ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

//                                   y
//                                   |
//                   Q2              |              Q1    
// __________________________________|__________________________________ x
//                                   |
//                   Q3              |              Q4  
//                                   |


using System;
using System.Globalization; 

namespace URI_1041 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y != 0.0 ) {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0.0 && y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}
