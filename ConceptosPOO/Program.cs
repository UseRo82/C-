using System;

namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();

            var miVariable = new { Nombre = "Juan", Edad = 40 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var otraVariable = new { Nombre = "Pepe", Edad = 36 };

            miVariable = otraVariable;
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otroPunto = new Punto();


            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorObjetos()}");
        }

    }
}
