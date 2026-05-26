using System;
using System.Collections;
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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }
        clsArboBinario Arbol = new clsArboBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos ObjNodo = new clsNodos();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);
            Arbol.Recorrer(dgvArbol);
            Arbol.Recorrer(treeView1);
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {

        }

        private void rbtIn_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvArbol);
            Arbol.Recorrer(treeView1);
            Arbol.Recorrer(treeView1);
        }
    }
}
