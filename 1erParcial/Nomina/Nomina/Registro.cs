using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class Registro
    {
        public String Nombre { get; set; }
        public int Salario { get; set; }

        public Registro() { }// construcor

        public String Datos()
        {
            return Nombre + " " + Salario.ToString();
        }
    }
}
