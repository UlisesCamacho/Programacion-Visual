using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Videojuego
    {
        public String nombre { get; set; }
        public int año { get; set; }
        public Videojuego(){ }
        public String datos()
        {
            return nombre + " " + año.ToString();
        }
    }
}
