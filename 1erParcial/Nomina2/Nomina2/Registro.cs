using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina2
{
    public class Registro
    {
        public String nombre { get; set; }
        public int salario { get; set; }
        public Registro() { }
        public String Datos()
        {
            return nombre + " " + salario.ToString();
        }


    }
  

}
