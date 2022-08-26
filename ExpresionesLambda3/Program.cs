using System;

namespace ExpresionesLambda3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona();
            P1.Nombre = "Juan";
            P1.Edad = 36;

            Persona P2 = new Persona();
            P2.Nombre = "Miguel";
            P2.Edad = 36;

            Compara comparaEdad = (persona1, persona2) => persona1 == persona2;

            Compara2 comparaNombre = (persona1a, persona2a) => persona1a == persona2a;

            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));

            Console.WriteLine(comparaNombre(P1.Nombre, P2.Nombre));
        }
        public delegate bool Compara(int edad1, int edad2);
        public delegate bool Compara2(string n1, string n2);
    }
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
