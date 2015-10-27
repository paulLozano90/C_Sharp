using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPractica
{
    public class PuestoIncorrectoException : Exception
    {
        public PuestoIncorrectoException(String msg) : base(msg)
        {

        }
    }
}
