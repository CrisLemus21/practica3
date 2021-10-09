using estudiantes.Data;
using estudiantes.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiantes.Negocio
{
    class ClsEStudiante : ClsREstudiante
    {
        public void guardar(estudiante es)
        {
            create(es);
        }
    }
}
