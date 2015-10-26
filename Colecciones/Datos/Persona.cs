using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.Datos
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //Si queremos hacerlo mejor que el safecasting

        public override string ToString()
        {
            return String.Format("{0} {1} ", Nombre, Apellidos);

        }
    }
}
