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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {
            dgvPila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        clsPila Pila = new clsPila();
       
     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            clsNodos n = new clsNodos();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            Pila.Agregar(n);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstPila);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
      
            if (Pila.Primero != null)
            {
                lblCodigoE.Text = Pila.Primero.Codigo.ToString();
                lblNombreE.Text = Pila.Primero.Nombre;
                lbltramiteE.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
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
