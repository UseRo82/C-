using System;

namespace ArraysForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array.
            var valores = new[] { 6, 56, 7.85, 4, 1.65, 9, 86.45 };

            //Recorrido del array para saber la cantidad de elementos que hay, se hace con Lenght.
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            //Bucle foreach.
            foreach(double val in valores)
            {
                Console.WriteLine(val);
            }

            //Array.
            Empleados Ana = new Empleados("Ana", 45);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;
            arrayEmpleados[2] = new Empleados("Pablo", 43);

            for(int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }

            //Bucle foreach.
            foreach(Empleados contador in arrayEmpleados)
            {
                Console.WriteLine(contador.getInfo());
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
        public String getInfo()
        {
            return "Nombre: " + nombre + ". Edad: " + edad;
        }

        private String nombre;
        private int edad;
    }
}
