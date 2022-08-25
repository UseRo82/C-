using System;
using System.Collections.Generic;

namespace Colecciones3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("introduce elementos en la colección. Presione '0' para salir.");

            int elem = 1;

            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }
            numeros.RemoveAt(numeros.Count -1); // Para eliminar el 0 de la lista.

            Console.WriteLine("Elementos introducidos:");

            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
