using System;

namespace Herencia
{
    internal class Program
    {
        //Método principal. Método Main.
        static void Main(string[] args)
        {
            //Instancias.
            Caballo MiCaballo = new Caballo("Babieca");

            IMamiferosTerrestres IMiCaballo = MiCaballo;

            Humano Persona = new Humano("Juan");
            Gorila MiMono = new Gorila("Copito");
            HumEur Europeos = new HumEur("Españoles");

            //Principio de sustitución.
            Mamiferos animal = new Caballo("Bucéfalo");

            Object miAnimal = new Caballo("Bucéfalo");
            Object miPersona = new Humano("Pepe");
            Object miMamifero = new Mamiferos("Peter");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = MiCaballo;
            almacenAnimales[1] = Persona;
            almacenAnimales[2] = MiMono;

            for(int i = 0; i< 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamiferos miMamife = new Mamiferos("");

            Europeos.conquistar();
            Persona.getNombre();
            MiCaballo.getNombre();
            MiMono.getNombre();
            Europeos.getNombre();

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("Número de patas de Babieca: " + IMiCaballo.numeroPatas());

            Lagartija Juanita = new Lagartija("Juanita");

            Juanita.getNombre();
            Juanita.respirar();

            Humano Persona2 = new Humano("Eusebio");
            
            Persona2.getNombre();
            Persona2.respirar();
        }
    }
    //Interface.
    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }
    interface IAnimalesDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }
    interface ISaltoPatas
    {
        int numeroPatas();
    }
    //Clase abstracta.
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar.");
        }
        //Método abstracto.
        public abstract void getNombre();

    }
    class Mamiferos : Animales
    {
        //Constructor.
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo.");
        }
        //Método.
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de las crías.");
        }
        //Método.
        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser mamífero es: " + nombreSerVivo);
        }
        //Campo de clase.
        private String nombreSerVivo;
    }
    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar.");
        }
    }
    //Clase que hereda de Mamiferos. Se hace referencia a ella con dos puntos ":".
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoPatas
    {
        //Constructor.
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar.");

            respirar();
        }
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }
        public string tipoDeporte()
        {
            return "Hípica";
        }
        public Boolean esOlimpico()
        {
            return true;
        }
        int ISaltoPatas.numeroPatas()
        {
            return 2;
        }
    }
    //Clase que hereda de Mamiferos.
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar() //seales: es para sellar el método y que no se pueda reescribir. Se pone detrás de public.
        {
            Console.WriteLine("Puedo pensar.");
        }
    }
    //Clase que hereda de Mamiferos.
    class Gorila : Mamiferos, IMamiferosTerrestres //seales: es para sellar la clase y que no se puedan derivar más clases a partir de esta. Se pone delante de class.
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado.");
        }
        public void trepar()
        {
            Console.WriteLine("Puedo trepar.");
        }
        public int numeroPatas()
        {
            return 2;
        }
    }
    class Lagartija : Animales
    {
        //Constructor.
        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }
        //Atributo.
        private String nombreReptil;
    }
    //Clase que hereda de Humanos que a su vez hereda de clase Mamiferos.
    class HumEur : Humano
    {
        public HumEur(String nombreHumEur): base(nombreHumEur)
        {

        }
        public void conquistar()
        {
            Console.WriteLine("Los europeos conquistamos el mundo.");
        }
    }
}
