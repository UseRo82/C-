using System;

namespace Enum
{
    enum Estaciones
    {
        Primavera, 
        Verano, 
        Otoño, 
        Invierno
    };
    class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primavera; //Si queremos pasar un tipo enumerado a valor nulo: Estaciones? alergia = null;

            String La_alergia = alergia.ToString(); //Si queremos pasar un tipo enumerado a String.

            Console.WriteLine(alergia);
            Console.WriteLine(La_alergia);
        }
    }
}
