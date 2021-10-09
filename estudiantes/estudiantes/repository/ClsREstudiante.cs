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
    class ClsREstudiante : IEstudiante
    {
        public void create(estudiante estudiantes)
        {
           //coneccion base de datos
           using(EstudiantesEntities coneccion_base= new EstudiantesEntities()) {

                try
                {
                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiantes.nombresEstudiante;
                    est.apellidos = estudiantes.apellidos;
                    est.usuario = estudiantes.usuario;
                    est.contrasenia = estudiantes.contrasenia;

                    coneccion_base.estudiante.Add(est);
                    coneccion_base.SaveChanges();
                    MessageBox.Show("Se ha guardado un nuevo estudiante");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error se debe a " + ex);
                }


            }
        }

        public void delete(estudiante estudiante)
        {
           
        }
    }
}
