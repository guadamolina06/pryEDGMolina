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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            clsNodos ObjNodo = new clsNodos();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstLista);
            Lista.Recorrer("ListaDoble.csv");

            txtCodigo.Text = " ";
            txtTramite.Text = " ";
            txtNombre.Text = " ";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null) 
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer("ListaDoble.csv");


            }
        }
    }
}
