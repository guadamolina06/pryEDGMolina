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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        clsCola fila = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos n = new clsNodos();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
           
            fila.Agregar(n);
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);
            
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigoE.Text = fila.Primero.Codigo.ToString();
                lblNombreE.Text = fila.Primero.Nombre;
                lbltramiteE.Text = fila.Primero.Tramite;
                fila.eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
            else
            {
                lblCodigoE.Text = "";
                lblNombreE.Text = "";
                lbltramiteE.Text = "";
            }
        }
    }
}
