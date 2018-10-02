using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosEstudiar
{
    [Serializable]
    public class Registro
    {
       public int entero { get; set; }
        public String cadena { get; set; }
        public  Registro(){}
        public String datos()
        {
            return cadena + " "+ entero.ToString() ;
        }
        


    }
}
