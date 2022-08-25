using System;

namespace UsoChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;

                int resultado = numero + 20; //checked (numero + 20); Así también puede ponerse.

                Console.WriteLine(resultado);
            }
            
        }
    }
}
