using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Profesor
    {
        public String Nombre;
        public String ApellidoP;
        public String ApellidoM;
        public int clave;

        public Profesor(String n,String p, String m,int c)
        {
            Nombre = n;
            ApellidoP = p;
            ApellidoM = m;
            clave = c;
        }

        public String RegresaNombre()
        {
            return Nombre + " " + ApellidoP + " " + ApellidoM + ""+clave.ToString();
        }

    }
}
