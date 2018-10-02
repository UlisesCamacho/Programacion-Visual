using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Computadora
    {
        public String modelo { get; set; }
        public String marca { get; set; }
        public String procesador { get; set; }

        public Computadora() { }
        public String datos()
        {
            return modelo + " " + marca + " " + procesador;
        }

    }
}
