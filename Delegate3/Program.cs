using System;
using System.Collections.Generic;
namespace Delegate3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personas> list = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Juana";
            p1.Edad = 65;

            Personas p2 = new Personas();
            p2.Nombre = "Miguel";
            p2.Edad = 25;

            Personas p3 = new Personas();
            p3.Nombre = "Ana";
            p3.Edad = 35;

            list.AddRange(new Personas[]{p1, p2, p3});

            Predicate<Personas> elpredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = list.Exists(elpredicado);

            if (existe) Console.WriteLine("Hay personas que se laman Juan.");
            else Console.WriteLine("No hay personas que se llamen Juan.");
        }
        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
    }
    class Personas
    {
        private string nombre;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }
    }
}
