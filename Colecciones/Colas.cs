using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones.Datos;

namespace Colecciones
{
    public class Colas
    {
        public static void Main(string[] args)
        {
            Queue cola=new Queue();

            cola.Enqueue("Hola");
            cola.Enqueue("soy");
            cola.Enqueue(new Persona() {Apellidos = "Gomez",Nombre = "Pepe"});
            cola.Enqueue(22);

            foreach (var elemento in cola)
            {  
                //Para que nos muestre el nombre completo:

                //Queda mas elegante hacerlo con el safe casting que con el if

                //if (elemento is Persona)
                //    Console.WriteLine(((Persona)elemento).Nombre);
                //else
                //    Console.WriteLine(elemento);

                //Safe casting, siempre comprobando despues si es null

                //var p = elemento as Persona;

                //if (p != null)
                //    Console.WriteLine(p.Nombre);
                //else
                //    Console.WriteLine(elemento);

                //La mejor manera es haciendo un toString en la clase

                Console.WriteLine(elemento);
            }

            //Esta manera es mucha mas comoda para leer y manejarlos
            Queue<Persona> colaGen=new Queue<Persona>();

            colaGen.Enqueue(new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });
            colaGen.Enqueue(new Persona()
            {
                Apellidos = "Garcia",
                Nombre = "Jose"
            });

            foreach (var persona in colaGen)
            {              

                Console.WriteLine("{0} {1}",persona.Nombre,persona.Apellidos);
            }

            Console.ReadLine();
        }
    }
}
