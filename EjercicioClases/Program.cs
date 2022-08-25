using System;

namespace EjercicioClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion F18 = new Avion();
            Coche Seat = new Coche();

            F18.arrancarMotor();
            F18.conducir();
            F18.pararMotor();

            Seat.arrancarMotor();
            Seat.conducir();
            Seat.pararMotor();
        }
    }

    class Vehiculos
    {
        public void arrancarMotor()
        {
            Console.WriteLine("El motor está arrancado.");
        }
        public void pararMotor()
        {
            Console.WriteLine("El motor está parado.");
        }
        public virtual void conducir()
        {
            Console.WriteLine("Estoy conduciendo.");
        }

    }
    class Avion : Vehiculos
    {
        public override void conducir()
        {
            //base.Conducir(); Así sería para que utilizara el método Conducir de la clase base, clase Vehiculos.
            Console.WriteLine("Estoy pilotando un avión.");
        }
    }
    class Coche : Vehiculos
    {
        public override void conducir()
        {
            Console.WriteLine("Estoy conduciendo un coche.");
        }
    }
}
