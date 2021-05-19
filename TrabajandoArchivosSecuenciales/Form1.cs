using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajandoArchivosSecuenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaracion del objeto
        ArchivosSecuenciales obj = new ArchivosSecuenciales();
        private void altasDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Altas();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultaGeneral(listView1);
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarNombre(listView1);
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarEspecialidad(listView1);
        }
    }
}
