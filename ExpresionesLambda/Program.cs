using System;

namespace ExpresionesLambda
{
    internal class Program
    {
        public delegate int Operaciones(int numero1, int numero2);
        static void Main(string[] args)
        {
            //Uso del delegate.
            Operaciones operacion = new Operaciones((num1, num2) => num1 + num2);

            Console.WriteLine(operacion(4, 7));
        }
    }
}
