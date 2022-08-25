using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args) //Método.
        {

            const double PI = 3.1416;

            Console.WriteLine("Introduce radio:");
            double radio=double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area=Math.Pow(radio,2)*PI;

            Console.WriteLine($"El area del circulo es: {area}");

        }
    }
}


