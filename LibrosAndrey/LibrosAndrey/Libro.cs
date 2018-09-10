using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosAndrey
{
   public class Libro
    {
        public String nombre { get; set; }
        public int year { get; set; }
        public Libro(String n, int y) {
            this.nombre = n;
            this.year = y;
        }
        public String datos()
        {
            return nombre + " " + year.ToString();
        }
    }
}
