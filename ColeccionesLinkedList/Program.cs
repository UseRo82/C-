using System;
using System.Collections.Generic;

namespace ColeccionesLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int> ();

            foreach(int num in new int[] { 1, 2, 3, 4, 5, 6, })
            {
                numeros.AddLast(num);
            }
            //Para eliminar elementos.
            numeros.Remove(6);

            //Recorrer con bucle foreach
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
            //Recorrer con bucle for.
            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int num = nodo.Value;

                Console.WriteLine(num);
            }
        }
    }
}
