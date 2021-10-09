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
    class ClsRMateria : Imaterias
    {
        public void crear(materia Materia)
        {
            using (EstudiantesEntities materi = new EstudiantesEntities())
            {
                try
                {
                    materia mate = new materia();
                    mate.idMateria = Materia.idMateria;
                    mate.nombreMateria = Materia.nombreMateria;

                    materi.materia.Add(mate);
                    materi.SaveChanges();

                    MessageBox.Show("La materia se ha guardado correctamente");
                    

                }
                catch(Exception error)
                {
                    MessageBox.Show("se detectado un errormas infomacion\n" + error);
                }
            }

        }

        public void borrar(materia Materia)
        {
            throw new NotImplementedException();
        }
    }
}
