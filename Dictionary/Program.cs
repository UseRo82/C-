using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //Rellenando el diccionario.

            edades.Add("Felipe", 76);
            edades.Add("Javier", 65);

            edades["María"] = 25;
            edades["Juan"] = 62;

            //Recorriendo diccionario.
            foreach(KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre: {0} Edad {1}", persona.Key, persona.Value);
            }
        }
    }
}
