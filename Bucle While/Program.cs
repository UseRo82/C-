using System;

namespace Bucle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿deseas entrar en el bucle while?");

            string respuesta = Console.ReadLine();

            while(respuesta != "no")
            {
                Console.WriteLine("estás dentro del bucle while.");
                Console.WriteLine("introduce tu nombre.");

                string nombre = Console.ReadLine();
                Console.WriteLine($"te llamas {nombre}");
                Console.WriteLine("Saldrás del bucle while cuando pongas no.");
                Console.WriteLine("¿deseas repetir otra vez?");

                respuesta = Console.ReadLine();
            }

            Console.WriteLine("has salido del bucle");
        }
    }
}
