using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPractica
{
    public class MenuIncorrectoException :Exception
    {
        public MenuIncorrectoException(String msg) : base(msg)
        {

        }
    }
}
