using System;

namespace Metodos3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Suma(7,5));
        }  

        static int Suma(int num1, int num2) => num1 + num2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;

    }
}
//Sobrecarga de métodos.