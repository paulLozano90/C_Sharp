using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSqlServer.Model
{
    public partial class Cargo
    {
        public override string ToString()
        {
            return $"{nombre} {salarioBase}";
        }
    }
}
