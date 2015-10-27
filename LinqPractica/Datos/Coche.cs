using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractica.Datos
{
    public class Coche
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public int Matriculacion { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -- {1} -- {2} ", Matricula,Modelo,Matriculacion);
        }

    }
}
