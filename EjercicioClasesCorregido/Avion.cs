using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesCorregido
{
    internal class Avion : Vehiculos
    {
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando.");
        }
        public void Despegar()
        {
            Console.WriteLine("Despegando.");
        }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo avión");
        }
    }
}
