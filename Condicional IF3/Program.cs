using System;

namespace Condicional_IF3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carnet = "no";

            Console.WriteLine("Evaluación carnet de conducir");
            Console.WriteLine("Introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("¿Tienes carnet de conducir?");

                carnet = Console.ReadLine();

            }

            if (edad >= 18 && carnet == "si") Console.WriteLine("Puedes conducir");

            else Console.WriteLine("No puedes conducir");

        }
    }
}
