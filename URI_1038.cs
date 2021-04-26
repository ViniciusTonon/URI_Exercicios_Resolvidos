// URI 1038: Lanche.

// Com base na tabela abaixo, escreva um programa que leia o código de um item
// e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

//        CÓDIGO          Especificação        Preço
//          1            Cachorro Quente      R$4.00
//          2                X-Salada         R$4.50
//          3                X-Bacon          R$5.00
//          4            Torrada Simples      R$2.00
//          5              Refrigerante       R$1.50


using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                valor = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                valor = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                valor = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                valor = quantidade * 2.00;
            }
            else
            {
                valor = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
