using System;

namespace Bucle_While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);
            int mNumero = 101;
            int intentos = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");

            while (aleatorio != mNumero)
            {
                intentos++;

                mNumero = int.Parse(Console.ReadLine());

                if (mNumero > aleatorio) Console.WriteLine("El número es menor");
                if (mNumero < aleatorio) Console.WriteLine("El numero es mayor");
            }

            Console.WriteLine($"Correcto, intentos: {intentos}");

            Console.WriteLine("Ha finalizado");

        }
    }
}
