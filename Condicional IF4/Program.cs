using System;

namespace Condicional_IF4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce nota 1:");
            double par1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 2:");
            double par2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 3:");
            double par3 = Int32.Parse(Console.ReadLine());

            if (par1 >= 5 && par2 >= 5 && par3 >= 5) Console.WriteLine($"La nota media es {(par1 + par2 + par3) / 3}.");

            else Console.WriteLine("Has suspendido.");
        }
    }
}
