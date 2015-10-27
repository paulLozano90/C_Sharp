using System;
using System.Collections.Generic;
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

            //INSERT:
            var p = new Cargo()
            {
                nombre = "Tecnico IT",
                salarioBase = 3000
            };
            //ctx.Cargo.Add(p);
            //ctx.SaveChanges();

            //MOSTRAR LISTA
            foreach (var puesto in ctx.Cargo)
            {
                Console.WriteLine(puesto);
            }
            Console.ReadLine();
        }
    }
}
