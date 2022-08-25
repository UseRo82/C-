using System;

namespace PropiedadesAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Agustin.");

            empleado1.SALARIO = 1200;

            empleado1.SALARIO += 350; //Para incrementar el salario.

            Console.WriteLine("El salario del empleado es: " + empleado1.SALARIO);
        }
    }
    class Empleado
    {
        //Atributos.
        public double SALARIO
        {
            get {return this.salario;} //Devuelve salario.
            set { this.salario = evaluaSalario(value); } //Almacena en la variable salario lo que dice el método salario.
        }
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
        /*
        //Setter.
        public void setSalario(double salario)
        {
            if(salario < 0){
                Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario.");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }
        public double getSalario()
        {
            return salario;
        }*/
        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
    }
}
