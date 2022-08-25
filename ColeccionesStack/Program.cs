using System;
using System.Collections.Generic;

namespace ColeccionesStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            foreach (int num in new int[6] {1, 2, 3, 4, 5, 6})
            {
                numeros.Push(num);
            }
            Console.WriteLine("Recorriendo Stack:");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            //Eliminando elemento Stack.
            Console.WriteLine("Eliminando elemnto.");

            numeros.Pop();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
