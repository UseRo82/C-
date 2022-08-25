using System;

namespace Condicion_IF2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluación de carnet de conducir.");

            Console.WriteLine("Introduce edad:");

            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Tienes carnet de conducir?");

            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet == "si")

                Console.WriteLine("Puedes conducir");

            else

                Console.WriteLine("No puedes conducir");
        }
    }
}
