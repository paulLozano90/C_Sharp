using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones.Datos;

namespace Colecciones
{
    //Para que funciones poner bien MAIN
    class Program
    {
        static void Mai(string[] args)
        {
            //Cola. 
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue(new Persona());

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());


            //Es lo mas parecido a un array dinamico
            ArrayList p = new ArrayList();
            p.Add(new Persona());
            p.Add(new Persona());
            p.Add("Pepe");
            p.Add(new Persona());
            p.Add(new Persona());
            p.Add("");
            p.Add(new Persona());

            Console.WriteLine(p[2]);
            Console.ReadLine();

            //Diccionario. Estructura de datos que se almacena con claves.
            //Para usarlo llamaremos directamente a la clave.
        }
    }
}
