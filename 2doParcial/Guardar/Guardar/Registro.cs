using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guardar
{
    class Registro
    {
        public String Nombre { get; set; }
        public int Clave { get; set; }

        public String DameDatos()
        {
            return Nombre + " " + Clave.ToString();
        }
    }
}
