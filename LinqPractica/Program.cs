using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqPractica.Datos;

namespace LinqPractica
{
    class Program
    {
        static List<Coche> listaCoches = new List<Coche>()
        {
            new Coche()
            {
                Matricula= "9125GKL",
                Modelo = "Seat Leon",
                Matriculacion = 2012
            },
            new Coche()
            {
                Matricula= "9875GZS",
                Modelo = "Seat Ibiza",
                Matriculacion = 2013
            },
            new Coche()
            {
                Matricula= "9151GBS",
                Modelo = "Seat Cordoba",
                Matriculacion = 2011
            },
            new Coche()
            {
                Matricula= "8445JHW",
                Modelo = "Audi Q5",
                Matriculacion = 2014
            },
            new Coche()
            {
                Matricula= "1654JYF",
                Modelo = "Audi A7",
                Matriculacion = 2015
            },
            new Coche()
            {
                Matricula= "6451JBS",
                Modelo = "Audi R8",
                Matriculacion = 2013
            },
        };

        public static void listar()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("LISTA DE VEHICULOS");
            Console.WriteLine("------------------");

            if (listaCoches.Count == 0)
                Console.WriteLine("Vacia");
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("MATRICULA - MODELO - AÑO MATRICULACION");
                Console.WriteLine("--------------------------------------");

                for (int i = 0; i < listaCoches.Count; i++)
                {
                    Console.WriteLine("{0} -- {1} -- {2}", listaCoches[i].Matricula, listaCoches[i].Modelo, listaCoches[i].Matriculacion);
                }
            }
        }

        public static void busquedaGeneral(string nombreBusqueda)
        {
            var busqueda = from o in listaCoches select o;
            
            Console.Write(nombreBusqueda);
            var elemento = Console.ReadLine();

            if (nombreBusqueda == "Matricula")
            {
                busqueda = from o in listaCoches where o.Matricula.Contains(elemento) select o;
                //var busqueda = listaCoches.Where(o => o.Matricula == elemento);
            }
            else if (nombreBusqueda == "Modelo")
            {
                busqueda = from o in listaCoches where o.Modelo.Contains(elemento) select o;
                //var busqueda = listaCoches.Where(o => o.Modelo == elemento);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("MATRICULA - MODELO - AÑO MATRICULACION");
            Console.WriteLine("--------------------------------------");

            foreach (var coche in busqueda)
            {
                Console.WriteLine("{0} -- {1} -- {2} ", coche.Matricula, coche.Modelo, coche.Matriculacion);
            }

        }

        public static void bMatricula()
        {
            Console.Write("Matricula:");
            var matricula = Console.ReadLine();

            var bMatricula = from o in listaCoches where o.Matricula.Equals(matricula) select o;
            //var bMatricula = listaCoches.FirstOrDefault(o => o.Matricula == matricula);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("MATRICULA - MODELO - AÑO MATRICULACION");
            Console.WriteLine("--------------------------------------");

            foreach (var elemento in bMatricula)
            {
               Console.WriteLine("{0} -- {1} -- {2} ", elemento.Matricula, elemento.Modelo, elemento.Matriculacion);
            }
           
        }

        public static void bModelo()
        {
            Console.Write("Modelo:");
            var modelo = Console.ReadLine();

            var bModelo = from o in listaCoches where o.Modelo.Contains(modelo) select o;
            //var bModelo = listaCoches.Where(o => o.Modelo == modelo);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("MATRICULA - MODELO - AÑO MATRICULACION");
            Console.WriteLine("--------------------------------------");

            //foreach (var elemento in bModelo1)
            //{
            //    Console.WriteLine("{0} -- {1} -- {2} ", elemento.Matricula, elemento.Modelo, elemento.Matriculacion);
            //}
        }

        public static void bFabricacion()
        {
            Console.Write("Año de matriculacion:");
            int matriculacion = Convert.ToInt32(Console.ReadLine());

            //var bMatriculacion = from o in listaCoches where o.Matriculacion.Equals(matriculacion) && o.Modelo.Contains(modelo) select o;
            //var bMatriculacion = listaCoches.Where(o => o.Matriculacion == matriculacion && o.Modelo == modelo);
            var busqueda = listaCoches.Where(o => o.Matriculacion == matriculacion)
                          .OrderByDescending(o => o.Modelo).ThenByDescending(o => o.Matricula);

            if (!busqueda.Any())
                Console.WriteLine("No hay ningun coche con ese año de matriculacion");

            foreach (var coche in listaCoches)
            {
                Console.WriteLine(coche);
            }
        }

        static void Main(string[] args)
        {
            int menu = 0;

            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("ELIGE UNA BUSQUEDA:");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Por matricula");
                Console.WriteLine("2. Por modelo ");
                Console.WriteLine("3. Por modelo y año de fabricacion");
                Console.WriteLine("4. Listar todos los vehiculos");
                Console.WriteLine("5. Salir");
                Console.WriteLine("-------------------");
                menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //bMatricula();
                        busquedaGeneral("Matricula");
                        break;
                    case 2:
                        //bModelo();
                        busquedaGeneral("Modelo");
                        break;
                    case 3:
                        bFabricacion();
                        break;
                    case 4:
                        listar();
                        break;
                    case 5:
                        Console.WriteLine("HAS SALIDO CORRECTAMENTE.");
                        Environment.Exit(0);
                        break;
                }

            } while (menu != 5);

            Console.ReadLine();
        }
    }
}
