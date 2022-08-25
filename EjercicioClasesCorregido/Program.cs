using System;

namespace EjercicioClasesCorregido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avión.");

            Avion F16 = new Avion();

            F16.ArrancarMotor("buuuuuuuuffffff...");
            F16.Despegar();
            F16.Conducir();
            F16.Aterrizar();
            F16.PararMotor("Sheeee...");

            //..................................................//

            Console.WriteLine();

            //..................................................//

            Console.WriteLine("Probando el coche.");

            Coche Audi = new Coche();

            Audi.ArrancarMotor("Rrrrrrrr...");
            Audi.Acelerar();
            Audi.Conducir();
            Audi.Frenar();
            Audi.PararMotor("Yehhhhhhh...");

            //.................................................//

            Console.WriteLine();

            //.................................................//

            Console.WriteLine("Polimorfismo.");

            Vehiculos miVehiculo = Audi;

            miVehiculo.Conducir();

            //Cambiando su forma en tiempo de ejecución. Polimorfismo.
            miVehiculo = F16;

            miVehiculo.Conducir();
        }
    }

}
