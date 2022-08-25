using System;

namespace Bucle_Do_While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);
            int mNumero;
            int intentos = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");

            do
            {
                intentos++;
                try 
                {mNumero = int.Parse(Console.ReadLine()); 
                }
                catch(FormatException ex) //Si ponemos solamente Exception capturará todos los errores. Dentro de la pirámide de excepciones es el más alto.
                {
                    Console.WriteLine("Valor introducido incorrecto.");
                    mNumero = 0;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Valor introducido demasiado largo.");
                    mNumero = 0;
                }

                if (mNumero > aleatorio) Console.WriteLine("El número es menor");
                if (mNumero < aleatorio) Console.WriteLine("El numero es mayor");
            } while (aleatorio != mNumero);

                Console.WriteLine($"Correcto, intentos: {intentos}");

            Console.WriteLine("Ha finalizado");
        }
    }
}
