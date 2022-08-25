using System;

namespace Delegate
{
    internal class Program
    {
        //Definición del objeto delegado.
        delegate void ObjetoDelegado();
        static void Main(string[] args)
        {
            //Creación del objeto delegado apuntando a MensajeBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilización del delegado para llamar al método SaludoBienvenida.
            ElDelegado();

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado();
        }
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola acabo de llegar.");
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Hasta luego, me voy.");
        }
    }
}
