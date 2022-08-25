using System;

namespace UsoCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objetos tipo coche.
            Coche coche1 = new Coche();
            Coche coche2 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche1.getInfoCoche());
            
            Console.WriteLine(coche2.getInfoCoche());
            coche2.setExtras(true, "Cuero.");
            Console.WriteLine(coche2.getExtras());
        }
    }
    class Coche
    {
        //Constructor.
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }
        //Sobrecarga de constructor.
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
        //Método getter.
        public String getInfoCoche()
        {
            return "Información del coche: " + ruedas + " ruedas, " + largo + " de largo, " + ancho + " de ancho, ";
        }
        //Método setter.
        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        //Métodod getter.
        public String getExtras()
        {
            return "Extras del coche: " + "Tapicería: " + tapiceria + " Climatizador: " + climatizador;
        }
        //Propiedades de la clase Coche.
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}
  