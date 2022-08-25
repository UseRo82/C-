using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesCorregido
{
    internal class Coche : Vehiculos
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando.");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando.");
        }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo coche.");
        }
    }
}
