using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Impresora
    {
        public String modelo { get; set; }
        public String marca { get; set; }
        public int numeroDeImpresiones { get; set; }
        public Impresora() { }
        public String datos()
        {
            return modelo + " " + marca + " " + numeroDeImpresiones.ToString();
        }
    }
}
