using System;

namespace Condicional_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué edad tienes?");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad <= 17) Console.WriteLine("Eres menor de edad");

            else if (edad >= 18 && edad < 30) Console.WriteLine("Eres joven");

            else if (edad >= 30 && edad < 40) Console.WriteLine("Eres una persona madura");

            else if (edad >= 40 && edad < 65) Console.WriteLine("Empieza a cuidarte");

            else Console.WriteLine("Te queda poca vida");
        }
    }
}
