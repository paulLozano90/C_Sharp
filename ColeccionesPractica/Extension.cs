using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPractica
{
    //Para crear metodos de extension la clase tienen que 
    //se una clase STATIC. Una clase estatica solo tiene 
    //metodos estaticos. 
    public static class Extension
    {
        public static string Sustituye(this string original, string entrada, string salida)
        {
            var cadena = original.Replace(entrada, salida);
            return cadena;
        }
    }
}
