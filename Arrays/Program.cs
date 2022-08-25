using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma 1 de declarar un array.
            int[] edades;

            edades = new int[4];

            edades[0] = 15;
            edades[1] = 24;
            edades[2] = 76;
            edades[3] = 32;

            Console.WriteLine(edades[2]);

            //Forma 2 de declarar un array.
            int[] valores = { 34, 65, 76, 89};

            Console.WriteLine(valores[3]);

            //Array implícito.
            var datos = new[] { "Juan,", "Díaz", "España" };

            //Array de objetos.
            Empleados Ana = new Empleados("Ana", 45);

            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;

            //Array de tipos o clases anónimas.
            var personas = new[]
            {
                new{Nombre = "Pablo", Edad = 97},
                new{Nombre = "Juan", Edad = 56},
                new{Nombre = "Andrés", Edad = 43}
            };
            Console.WriteLine(personas[1]);

            //Array para recorrer con ciclo for.
            var valores2 = new[] { 3, 14, 3.96, 6, 43.28};

            //Recorrer array con bucle for.
            Console.WriteLine("Recorrido del array con bucle for: "); 
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(valores2[i]);
            }
        }
    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        String nombre;
        int edad;
    }
}
