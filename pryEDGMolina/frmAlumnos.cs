using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDGMolina
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
          clsArchivo objAlumno = new clsArchivo();
            objAlumno.NomArchi = "Alumnos.csv";
            objAlumno.Grabar(txtNombre.Text, txtCodigo.Text, cmbCarreras.Text);
            objAlumno.Recorrer(dgvAlumnos);
            txtNombre.Clear();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
                if (File.Exists(objCarrera.NomArchi)) objCarrera.Recorrer(cmbCarreras);

            clsArchivo objAlumno = new clsArchivo();
            objAlumno.NomArchi = "Alumnos.csv";
            if (File.Exists(objAlumno.NomArchi)) objAlumno.Recorrer(dgvAlumnos);
        }
    }
}
