using System;
using System.Collections.Generic;

namespace Colecciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); //Declarando una lista (colección de tipo lista).

            int[] listaNumeros = new int[] { 1, 2, 3, 4 ,5 };

            for(int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
