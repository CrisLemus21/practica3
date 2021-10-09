using estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiantes.services
{
    interface Imaterias
    {
        void crear(materia Materia);

        void borrar(materia Materia);
    }
}
