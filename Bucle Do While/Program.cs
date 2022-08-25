using System;

namespace Bucle_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 10;

            do
            {
                Console.WriteLine("Impresión " + z);

                z++;

            } while (z < 15) ;
        }
    }
}
