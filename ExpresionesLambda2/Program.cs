using System;
using System.Collections.Generic;

namespace ExpresionesLambda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            //Con bucle foreach.
            foreach (int numero in numerosPares) Console.WriteLine(numero);

            Console.WriteLine();

            //Con operador Lambd.
            numerosPares.ForEach(numero => Console.WriteLine(numero));
        }
    }
}
