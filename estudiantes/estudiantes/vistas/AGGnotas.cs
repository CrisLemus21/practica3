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
    public partial class AGGnotas : Form
    {
        public AGGnotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                notas datos = new notas();
                datos.idEstudiante = int.Parse(textBox1.Text);
                datos.idMateria = int.Parse(textBox2.Text);
                datos.idNotas = int.Parse(textBox3.Text);
                datos.nota = double.Parse(textBox4.Text);

                ClsNotass logi = new ClsNotass();
                logi.agregar(datos);
                this.Close();
            }
            catch
            {
                MessageBox.Show("por favor reyene todos los campos");
            }
        }
    }
}
