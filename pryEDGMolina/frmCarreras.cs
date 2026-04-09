using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDGMolina
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();    
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.Grabar(txtCarrera.Text);
            objCarrera.Recorrer(lstCarrera);
            txtCarrera.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.BorrarTodo();
            objCarrera.Recorrer(lstCarrera);
            txtCarrera.Clear();
        }
    }
}
