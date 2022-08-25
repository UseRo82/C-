using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesCorregido
{
    internal class Vehiculos
    {
        public void ArrancarMotor(String sonidoArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoArrancar}");
        }
        public void PararMotor(String sonidoParar)
        {
            Console.WriteLine($"Parar motor: {sonidoParar}");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Este es el código genérico para el método conducir.");
        }
    }
}
