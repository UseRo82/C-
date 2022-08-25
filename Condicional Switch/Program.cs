using System;

namespace Condicional_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donde quieres viajar, coche, tren o avión.");

            string medio = Console.ReadLine();

            switch (medio)
            {
                case "coche":
                    Console.WriteLine("velocidad media 100");
                    break;

                case "tren":
                    Console.WriteLine("velocidad media 200");
                    break;

                case "avión":
                    Console.WriteLine("velocidad media 500");
                    break;

                default:
                    Console.WriteLine("transporte incorrecto");
                    break;
            }

            Console.WriteLine("Elección terminada.");
        }
    }
}
