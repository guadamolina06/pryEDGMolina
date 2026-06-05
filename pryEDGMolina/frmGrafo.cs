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
    public partial class frmGrafo : Form
    {
        clsGrafo grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
        }
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigen);
            grafo.MostrarCiudades(cmbDestino);
            grafo.MostrarCiudades(cmbEliminarOrigen);
            grafo.MostrarCiudades(cmbEliminarDestino);
            grafo.MostrarCiudades(cmbListarDestino);
            grafo.MostrarCiudades(cmbhasta);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtPrecioCarga.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un precio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCarga.Text, out decimal p) || p <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int origen = cmbOrigen.SelectedIndex;
            int destino = cmbDestino.SelectedIndex;

            if (origen == destino)
            {
                MessageBox.Show("Origen y destino no pueden ser iguales.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grafo.Agregar(origen, destino, p);
            txtPrecioCarga.Clear();
            MessageBox.Show("Viaje cargado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int origen = cmbEliminarOrigen.SelectedIndex;
            int destino = cmbEliminarDestino.SelectedIndex;

            decimal p = grafo.consultar(origen, destino);

            if (p > 0)
                txtPrecioE.Text = p.ToString("F2");
            else
            {
                txtPrecioE.Clear();
                MessageBox.Show("No existe ese viaje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int origen = cmbEliminarOrigen.SelectedIndex;
            int destino = cmbEliminarDestino.SelectedIndex;

            decimal p = grafo.consultar(origen, destino);
            if (p == 0)
            {
                MessageBox.Show("No existe ese viaje para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grafo.Eliminar(origen, destino);
            txtPrecioE.Clear();
            MessageBox.Show("Viaje eliminado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListarDestino_Click(object sender, EventArgs e)
        {
            grafo.MostrarDestinos(cmbListarDestino.SelectedIndex, dgvDestinos);
        }

        private void btnlistarorigenes_Click(object sender, EventArgs e)
        {
            grafo.MostrarOrigenes(cmbhasta.SelectedIndex, dgvDestinos);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvDestinos);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Borrar todos los viajes?", "Confirmar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grafo.BorrarTodo();
                dgvDestinos.Rows.Clear();
                dgvDestinos.Columns.Clear();
                MessageBox.Show("Todos los viajes fueron borrados.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
