using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Declaracion de libreria para trabajar archivos secuenciales

namespace TrabajandoArchivosSecuenciales
{
    class ArchivosSecuenciales
    {
        //Declaracion de propiedades
        public string Matricula;
        public string Nombre;
        public string Paterno;
        public string Materno;
        public string Especialidad;
        public int Semestre;
        public int Promedio;

        // Declaracion de los metodos Set-Get
        public string matricula
        {
            set { value = Matricula;}
            get { return (Matricula);}
        }
        public string nombre
        {
            set { value = Nombre; }
            get { return (Nombre); }
        }
        public string paterno
        {
            set { value = Paterno; }
            get { return (Paterno); }
        }
        public string materno
        {
            set { value = Materno; }
            get { return (Materno); }
        }
        public string especialidad 
        {
            set { value = Especialidad; }
            get { return (Especialidad); }
        }
        public int semestre
        {
            set { value = Semestre; }
            get { return (Semestre); }
        }
        public int promedio
        {
            set { value = Promedio; }
            get { return (Promedio); }
        }
        //Metodo para agregar datos al archivo
        public void Altas()
        {
            StreamWriter sw = new StreamWriter("..ArchivosDatos.txt", true, Encoding.ASCII);
            DialogBoxAltas altas = new DialogBoxAltas();
            if (altas.ShowDialog() == DialogResult.OK)
            {
                sw.WriteLine(altas.matricula);
                sw.WriteLine(altas.nombre);
                sw.WriteLine(altas.paterno);
                sw.WriteLine(altas.materno);
                sw.WriteLine(altas.especialidad);
                sw.WriteLine(altas.semestre);
                sw.WriteLine(altas.promedio);
                MessageBox.Show("Datos del alumno guardados en el archivo", "Archivos Secuenciales",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sw.Close();
        }
        public void ConsultaGeneral(ListView caja)
        {
            StreamReader sr = new StreamReader("..ArchivosDatos.txt");
            string matricula = sr.ReadLine();
            string nombre = sr.ReadLine();
            string paterno = sr.ReadLine();
            string materno= sr.ReadLine();
            string especialidad = sr.ReadLine();
            string semestre = sr.ReadLine();
            string promedio = sr.ReadLine();
            while (matricula != null)
            {
                ListViewItem datos = new ListViewItem(matricula);
                datos.SubItems.Add(nombre);
                datos.SubItems.Add(paterno);
                datos.SubItems.Add(materno);
                datos.SubItems.Add(especialidad);
                datos.SubItems.Add(semestre);
                datos.SubItems.Add(promedio);
                caja.Items.Add(datos);
                matricula = sr.ReadLine();
                nombre = sr.ReadLine();
                paterno = sr.ReadLine();
                materno = sr.ReadLine();
                especialidad = sr.ReadLine();
                semestre = sr.ReadLine();
                promedio = sr.ReadLine();
            }
            sr.Close();
        }
        public void MostrarNombre(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (nombre.ToLower() == busca.nombre.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El nombre del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarEspecialidad(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarEspecialidad busca = new DialogBoxBuscarEspecialidad();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (especialidad.ToLower() == busca.especialidad.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("La especialidad del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarSemestre(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarSemestre busca = new DialogBoxBuscarSemestre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (semestre.ToLower() == busca.semestre.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El semestre del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarMatricula(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarMatricula busca = new DialogBoxBuscarMatricula();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (matricula.ToLower() == busca.matricula.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("La matricula del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarPromedio(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarPromedio busca = new DialogBoxBuscarPromedio();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (promedio.ToLower() == busca.promedio.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El promedio del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
