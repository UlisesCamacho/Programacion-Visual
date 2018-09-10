using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivo
{
    public class Registro
    {
        public String nombre { get; set; }
        public int clave { get; set; }
       public Registro() { }

        public String datos()
        {
            return nombre + " " + clave.ToString();
        }
    }
}
