using System;
using System.Collections.Generic;

namespace Colecciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Elige número de elemntos: ");

            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Elementos introducidos:");

            for(int i = 0; i < elem; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
