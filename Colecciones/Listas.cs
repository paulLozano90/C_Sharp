using Colecciones.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Listas
    {
        //Para que funciones poner bien MAIN
        public static void Mai(string[] args)
        {
            //OJO! Las listas empiezan por 0
            List<Persona> person=new List<Persona>();

            //Añadir elementos
            person.Add(new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });
            person.Add(new Persona()
            {
                Apellidos = "Garcia",
                Nombre = "Jose"
            });
            person.Add(new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });

            //Borrar un elemento de la lista:
            person.RemoveAt(2);

            //Para recorrer una lista, aparte del tipico foreach...
            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine("{0} {1}", person[i].Nombre,person[i].Apellidos);
            }

            Console.ReadLine();

        }
    }
}
