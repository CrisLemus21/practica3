using estudiantes.Data;
using estudiantes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudiantes.vistas
{
    public partial class materias : Form
    {
        public materias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                materia datos = new materia();
                datos.nombreMateria = textBox1.Text;
                datos.idMateria = int.Parse(textBox2.Text);

                ClsMateriass guar = new ClsMateriass();
                guar.crear(datos);
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("por favor reyene todos los campos");
            }
        }
    }
}
