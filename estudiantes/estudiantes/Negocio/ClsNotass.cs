using estudiantes.Data;
using estudiantes.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiantes.Negocio
{
    class ClsNotass : ClsRNotas
    {
        public void agregar(notas notass)
        {
            addn(notass);
        }
    }
}
