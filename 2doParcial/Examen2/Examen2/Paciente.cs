using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Paciente
    {
       public String nombrePaciente { get; set; }
       public String fecha { get; set; }
      public   String hora { get; set; }
      public  Doctor d;
        public Paciente()
        {
            d = new Doctor();
        }
    }
}
