using estudiantes.Data;
using estudiantes.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudiantes.repository
{
    class ClsRNotas : INotas
    {
        public void addn(notas Notas)
        {
            using(EstudiantesEntities coneccion_base = new EstudiantesEntities())
            {
                try
                {
                    notas not = new notas();
                    not.estudiante = Notas.estudiante;
                    not.idEstudiante = Notas.idEstudiante;
                    not.idMateria = Notas.idMateria;
                    not.nota = Notas.nota;
                    coneccion_base.notas.Add(not);
                    coneccion_base.SaveChanges();
                    MessageBox.Show("se han agregados las notas ");
                }
                catch
                {

                }
            }
        }

        
    }
}
