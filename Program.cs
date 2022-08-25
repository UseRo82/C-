﻿using System;

namespace ArrayReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el método main.");

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }
        static int[] LeerDatos()
        {
            Console.WriteLine("Elija elementos para el array.");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }
            return datos;
        }
    }
}
