using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPractica.Datos
{
    public enum Estudios
    {
        Basico, Medio, Superior, Doctor
    }
    public enum Puestos
    {
        Programador, Analista, DirectorProyectos, DirectorIt
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Estudios Estudio { get; set; }


        private Puestos _puesto;
        public Puestos Puesto
        {
            get { return _puesto; }
            set
            {
                if ((int)value > (int) Estudio)
                {
                    var msg = $"Su estudio actual {Estudio}, no permite optar al puesto deseado\n" +
                              $"{value}. Escoja otro puesto de menor rango, por favor.";
                    throw new PuestoIncorrectoException(msg);
                }
                _puesto = value;
            }
        }
        
        public override string ToString()
        {
            return String.Format("{0} ", Nombre);
        }
    }
}
