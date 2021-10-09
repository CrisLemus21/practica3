using estudiantes.Data;
using estudiantes.Negocio;
using estudiantes.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //estudiante es la tabla de base de datos chele 
                estudiante es = new estudiante();
                es.nombresEstudiante = no.Text;
                es.apellidos = ap.Text;
                es.usuario = usu.Text;
                es.contrasenia = con.Text;
                ClsEStudiante fk = new ClsEStudiante();
                fk.guardar(es);
            }
            catch
            {
                MessageBox.Show("por favor reyene todos los campos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            materias objV = new materias();
            objV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AGGnotas aGGnotas = new AGGnotas();
            aGGnotas.Show();
        }
    }
}
