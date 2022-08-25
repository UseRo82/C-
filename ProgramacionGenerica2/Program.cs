using System;

namespace ProgramacionGenerica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(2);

            AlmacenEmpleados<Secretaria> empleados2 = new AlmacenEmpleados<Secretaria>(2);

            AlmacenEmpleados<Electricista> empleados3 = new AlmacenEmpleados<Electricista>(2);

            empleados.agregar(new Director(3500));
            empleados.agregar(new Director(3200));

            empleados2.agregar(new Secretaria(1600));
            empleados2.agregar(new Secretaria(1300));

            empleados3.agregar(new Electricista(1900));
            empleados3.agregar(new Electricista(1700));
        }
    }
    //Clase genérica para empleados con restricción solo para empleados que tengan salario.
    class AlmacenEmpleados<T> where T: IparaEmpleados
    {
        //Constructor.
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        //Método para agregar elementos.
        public void agregar(T obj)
        {
            datosEmpleado[i] = obj;

            i++;
        }
        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;

        private T[] datosEmpleado;
    }
    interface IparaEmpleados
    {
        double getSalario();
    }
    class Director : IparaEmpleados
    {
        //Constructor.
        public Director(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Secretaria : IparaEmpleados
    {
        //Constructor.
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Electricista : IparaEmpleados
    {
        //Constructor.
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Estudiante //Esta clase no se puede implementar en la clase principal ya que no tiene salario. IparaEmpleados con su método getSalario.
    {
        private int edad;

        //Constructor.
        public Estudiante(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
    }
    
}
