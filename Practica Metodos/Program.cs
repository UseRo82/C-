using System;

namespace Practica_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(2,5);
        }

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es: {num1+num2}");
        }
    }
}
