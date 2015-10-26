using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones.Datos;

namespace Colecciones
{
    public class Diccionarios
    {
        public static void Main(string[] args)
        {
            //Almacenamos objetos referenciados por una key
            Dictionary<String,Persona> dic=new Dictionary<string, Persona>();
            
            dic.Add("Uno", new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });
            dic.Add("Dos", new Persona()
            {
                Apellidos = "Garcia",
                Nombre = "Jose"
            });
            dic.Add("Tres", new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });

            Console.WriteLine("{0} {1}", dic["Dos"].Nombre, dic["Dos"].Apellidos);

            if (dic.ContainsKey("Dos"))
                dic.Remove("Dos");

            Console.WriteLine("Elemento {0} borrado!", dic.ContainsKey("Dos"));

            foreach (var elemento in dic.Keys)
            {
                Console.WriteLine(dic[elemento].Nombre);
            }

            Console.ReadLine();
        }
    }
}
