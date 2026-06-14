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
    public partial class frmListaSimple : Form
    {
        clsListaSimple listaSimple = new clsListaSimple();
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            clsNodos nuevo = new clsNodos();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            listaSimple.Agregar(nuevo);
            listaSimple.Recorrer(dgvListaSimple);
            listaSimple.Recorrer(lstLista);
            listaSimple.Recorrer(cmbCodigo);
            listaSimple.Recorrer("ArchivoPila.csv");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaSimple.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            listaSimple.Recorrer(dgvListaSimple);
            listaSimple.Recorrer(lstLista);
            listaSimple.Recorrer(cmbCodigo);
            listaSimple.Recorrer("ArchivoPila.csv");
        }
    }
}
