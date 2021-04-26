// URI 1050: DDD

// Leia um número inteiro que representa um código de DDD para discagem interurbana.
// Em seguida, informe à qual cidade o DDD pertence, considerando os valores abaixo:
// (61) Brasilia - (71) Salvador - (11) São Paulo - (21) Rio de Janeiro - (32) Juiz de Fora -
// (19) Campinas - (27) Vitoria - (31) Belo Horizonte.
// Se a entrada for qualquer outro DDD que não esteja presente nos valores acima, 
// o programa deverá informar: DDD nao cadastrado

using System;
namespace URI_1050 {
    class Program {
        static void Main(string[] args) {
            int DDD = int.Parse(Console.ReadLine());

            if (DDD == 61) {
                Console.WriteLine("Brasilia");
            }
            else if (DDD == 71) {
                Console.WriteLine("Salvador");
            }
            else if (DDD == 11) {
                Console.WriteLine("Sao Paulo");
            }
            else if (DDD == 21) {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (DDD == 32) {
                Console.WriteLine("Juiz de Fora");
            }
            else if (DDD == 19) {
                Console.WriteLine("Campinas");
            }
            else if (DDD == 27) {
                Console.WriteLine("Vitoria");
            }
            else if (DDD == 31) {
                Console.WriteLine("Belo Horizonte");
            }
            else {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
