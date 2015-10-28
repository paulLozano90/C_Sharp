using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqSqlServer.Model;

namespace LinqSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new EmpleadosEntities();

            //INSERTAR ELEMENTO:
            var p = new Cargo()
            {
                nombre = "Tecnico IT",
                salarioBase = 3000
            };
            //ctx.Cargo.Add(p);
            //ctx.SaveChanges();

            //BORRAR ELEMENTO:
            var elemento = ctx.Cargo.Find(1);
            //if (elemento != null)
            //    ctx.Cargo.Remove(elemento);

            //MODIFICAR ELEMENTO:
            var elemento2 = ctx.Cargo.Find(3);
            //if (elemento != null)
            //    elemento2.salarioBase = 5500;

            //ctx.SaveChanges();

            //MOSTRAR LISTA
            Console.WriteLine("------------------------");
            Console.WriteLine("CARGO ----- SALARIO BASE");
            Console.WriteLine("------------------------");
            foreach (var puesto in ctx.Cargo)
            {
                Console.WriteLine(puesto);
            }

            //Alta empleado con puesto
            var e = new Empleados()
            {
                alta = DateTime.Now,
                nombre = "Alberto",
                //puesto = 3
                Cargo1 = elemento2,
            };
            //ctx.Empleados.Add(e);

            //Mostrar por cargos:
            Console.WriteLine("--------------------------------");
            Console.WriteLine("EMPLEADOS DE {0}",elemento2.nombre);
            Console.WriteLine("--------------------------------");
            foreach (var empleado in elemento2.Empleados)
            {
                Console.WriteLine(empleado.nombre);
            }

            Console.ReadLine();
        }
    }
}
