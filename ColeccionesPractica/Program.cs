using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeccionesPractica.Datos;

namespace ColeccionesPractica
{
    class Program
    {
        public static void alta()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("ESTUDIOS ACTUALES: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Basico");
            Console.WriteLine("2. Medio");
            Console.WriteLine("3. Superior");
            Console.WriteLine("4. Doctor");
            Console.WriteLine("----------------------");
            int estudios = Convert.ToInt16(Console.ReadLine());
            Estudios estudioActual = Estudios.Basico;

            switch (estudios)
            {
                case 1:
                    estudioActual = Estudios.Basico;
                    break;
                case 2:
                    estudioActual = Estudios.Medio;
                    break;
                case 3:
                    estudioActual = Estudios.Superior;
                    break;
                case 4:
                    estudioActual = Estudios.Doctor;
                    break;
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("PUESTO A SOLICITAR: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Programador");
            Console.WriteLine("2. Analista");
            Console.WriteLine("3. Director de Proyectos");
            Console.WriteLine("4. Director de IT");
            int puesto = Convert.ToInt16(Console.ReadLine());
            Puestos puestoElegido = Puestos.Programador;

            switch (puesto)
            {
                case 1:
                    puestoElegido = Puestos.Programador;
                    break;
                case 2:
                    puestoElegido = Puestos.Analista;
                    break;
                case 3:
                    puestoElegido = Puestos.DirectorProyectos;
                    break;
                case 4:
                    puestoElegido = Puestos.DirectorIt;
                    break;
            }

            try
            {
                //Añadir elementos
                emp.Add(new Empleado()
                {
                    Nombre = nombre,
                    Edad = edad,
                    Estudio = estudioActual,
                    Puesto = puestoElegido
                });

                Console.WriteLine("EMPLEADO AÑADIDO CORRECTAMENTE");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void listar()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("LISTA DE EMPLEADOS");
            Console.WriteLine("----------------------");

            if (emp.Count == 0)
                Console.WriteLine("Vacia");
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("NOMBRE -- EDAD -- ESTUDIOS -- PUESTO");
                Console.WriteLine("------------------------------------");

                for (int i = 0; i < emp.Count; i++)
                {
                    Console.WriteLine("{0} -- {1} -- {2} -- {3} ", emp[i].Nombre, emp[i].Edad, emp[i].Estudio, emp[i].Puesto);
                }
            }
        }

        public static void buscar()
        {
            Console.Write("Nombre a buscar:");
            var nombre = Console.ReadLine();

            //LINQ
            //Busca 3 personas con ese nombre ordenadas por el nombre
            var p = emp.Where(o => o.Nombre == nombre).OrderBy(o => o.Nombre).Take(3);
            //var p = from o in emp where o.Nombre.Contains(nombre) select o;

            //var p = emp.Where(o => o.Nombre.Contains(nombre)).OrderByDescending(o => o.Nombre);ç

            //Cuidado con el first que cuando no encuentra nada, devuelve un error. 
            //Mejor usar el FIRSTOFDEFAULT 

            Console.WriteLine("------------------------------------");
            Console.WriteLine("NOMBRE -- EDAD -- ESTUDIOS -- PUESTO");
            Console.WriteLine("------------------------------------");

            foreach (var empleado in p)
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} ", empleado.Nombre, empleado.Edad, empleado.Estudio, empleado.Puesto);
            }

        }

        static List<Empleado> emp = new List<Empleado>()
        {
            new Empleado()
            {
                Edad=22,
                Estudio = Estudios.Basico,
                Puesto = Puestos.Programador,
                Nombre = "Alber"
            },
            new Empleado()
            {
                Edad=22,
                Estudio = Estudios.Superior,
                Puesto = Puestos.DirectorProyectos,
                Nombre = "Albert"
            },
            new Empleado()
            {
                Edad=22,
                Estudio = Estudios.Medio,
                Puesto = Puestos.Analista,
                Nombre = "Alberto"
            },
            new Empleado()
            {
                Edad=22,
                Estudio = Estudios.Doctor,
                Puesto = Puestos.DirectorIt,
                Nombre = "Albertito"
            }
        };
        
        static void Main(string[] args)
        {
            int menu = 0;

            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("ELIGE UNA OPCION: ");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Alta de un empleado");
                Console.WriteLine("2. Lista de empleados");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("----------------------");
                menu = Convert.ToInt16(Console.ReadLine());

                //if (menu > 3)
                //{
                //    var msg = $"Eliga un numero correcto del menu, por favor.";
                //    throw new MenuIncorrectoException(msg);
                //}

                //try
                //{
                    switch (menu)
                    {
                        case 1:
                            alta();
                            break;
                        case 2:
                            listar();
                            break;
                        case 3:
                            buscar();
                            break;
                        case 4:
                            Console.WriteLine("HAS SALIDO CORRECTAMENTE.");
                            Environment.Exit(0);
                            break;
                    }
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}

            } while (menu != 4);
           
            Console.ReadLine();
        }
    }
}
