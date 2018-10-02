using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    [Serializable]
    class DesastreUbicado
    {
        public NDesastre n;
        public Ubicacion u;

        public DesastreUbicado()
        {
            n = new NDesastre();
            u = new Ubicacion();
        }

    }
}
