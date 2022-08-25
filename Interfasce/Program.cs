using System;

namespace Interfasce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisoTrafico av1 = new AvisoTrafico();

            av1.mostrarAviso();
            
            AvisoTrafico av2 = new AvisoTrafico("Jefatura provincial de Marid", "Sanción de velocidad: 300 $", "02-05-2022");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();
        }
    }
}
