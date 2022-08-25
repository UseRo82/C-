using System;

namespace Condicional_IF_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige nº mes para calcular comisión.");
            int nMes = Int32.Parse(Console.ReadLine());

            if (nMes >= 6) Console.WriteLine("Comisión de 1000 euros.");
            else Console.WriteLine("Sin comisión");

            Console.WriteLine("Ha terminado su elección.");
        }
    }
}
