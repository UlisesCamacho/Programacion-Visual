using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Grupo
    {
        public List<Alumno> la;
        private Profesor p;
        private int clave;
        public Grupo(int clave,List<Alumno> la, Profesor p)
        {
            this.la = la;
            this.p = p;
            this.clave = clave;
        }
        public List<Alumno> dameListaAlumno()
        {
            return la;
        }
        public Profesor dameProfesor()
        {
            return p;
        }
        public int dameClave()
        {
            return clave;
        }
    }
 }
