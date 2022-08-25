using System;

namespace ProgrmacionGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

            /*.agregar("Juan");
            archivos.agregar("María");
            archivos.agregar("Agustín");
            archivos.agregar("Ana");*/

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(1800));
            archivos.agregar(new Empleado(1300));

            Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getSalario());
        }
    }
    class AlmacenObjetos<T> //Para indicar a la clase que va a manejar cualquier tipo de objetos. <T>
    {
        private T[] datosElemento;
        private int i = 0;

        //Constructor.
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }
        public void agregar(T obj)
        {
            datosElemento[i] = obj;

            i++;
        }
        public T getElemento(int i)
        {
            return datosElemento[i];
        }
    }
    class Empleado
    {
       public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }
}
