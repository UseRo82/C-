using System;

namespace PropiedadesAcceso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Agutin");

            empleado1.SALARIO = 1350.80;

            Console.WriteLine("El salario del empleado es: " + empleado1.SALARIO);
        }
    }
    class Empleado
    {
        private double salario;
        private string nombre;

        //Constructor.
        public Empleado(string nombre)
        {
            this.nombre = nombre;  
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del empleado es: " + nombre);
        }
        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
        //Expresion body con operador lambda.
        public double SALARIO
        {
            get => this.salario;
            set => this.salario = evaluaSalario(value);
        }
    }

}
