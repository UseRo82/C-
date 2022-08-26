using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hola mi nombr e Juan y estoy aprendiendo a programar y mi nº de tfno es (+34)123-45-67 y mi código postal es 45221.";

            string patron = @"\+34";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado código +34");
            else Console.WriteLine("No hay código +34.");
        }
    }
}
