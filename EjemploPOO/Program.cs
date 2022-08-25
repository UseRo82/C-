using System;

namespace EjemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //Creación de objeto de tipo círculo.

            miCirculo = new Circulo(); //Iniciación de variable objeto de tipo círculo. Instanciar una clase.

            Console.WriteLine("El área del círculo es " + miCirculo.CalculoArea(5));

            Circulo otroCirculo = new Circulo();

            Console.WriteLine("El área del segundo círculo es " + otroCirculo.CalculoArea(3));

            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.cambiaValorEuro(-1.7);
            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; //Propiedad de la clase Circulo. Con private queda encapsulada esa variable.

        public double CalculoArea(int radio) //Método de clase.
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        public double euro = 1.253; //Se pone public porque el valor del euro puede variar, con lo cual podemos poner otro valor de euro dentro de la clase Program en el método main, ej. obj.euro = 1.78.

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor) //Método para cambiar el valor en el método main.
        {
            if (nuevoValor < 0) euro = 1.253;

            else
                euro = nuevoValor;
        }
    }

}
