using System;
using System.IO;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.mensaje();
        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Users\rodri\Desktop\prueba.txt");

            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
        }
        public void mensaje()
        {
            Console.WriteLine("Hay {0} líneas.", contador);
        }
        //Destructor. Para cerrar el archivo.
        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
