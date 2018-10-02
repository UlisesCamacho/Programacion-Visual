using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    public class Videojuego
    {
        public String Nombre { get; set; }
        public int Salida { get; set; }

        public Videojuego(){ }

        public String dameDatos()
        {
            return Nombre + " " + Salida.ToString();
        }

    }
}
