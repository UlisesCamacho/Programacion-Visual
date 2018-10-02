using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    [Serializable]
    public class Alumno
    {
        public String nombre;
        public String apellidoP;
        public String apellidoM;
        public int clave; 

        public Alumno()
        {

        }
        public Alumno(String n,String ap, String am, int c)
        {
            nombre = n;
            apellidoM = am;
            apellidoP = ap;
            clave = c;
        }
        public String regresaNombre()
        {
            return nombre + " "+apellidoP + " "+apellidoM+ " " +clave.ToString();
        }
    }
}
