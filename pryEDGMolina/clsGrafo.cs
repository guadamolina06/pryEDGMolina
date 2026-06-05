using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDGMolina
{
    internal class clsGrafo
    {
        private string[] Ciudades = new string[] { "Cordoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta " };
        private decimal[,] precio = new decimal[5, 5];

        public void Agregar(int f, int c, decimal p)
        {
            precio[f, c] = p;
        }
        public void Eliminar(int f, int c)
        {
            precio[f, c] = 0;

        }
        public decimal consultar(int f, int c)
        {
            return precio[f, c];
        }
        public void Borrarodo()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    precio[f, c] = 0;
                }
            }
        }
        public void MostrarDestinos(int f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (int c = 0; c < 5; c++)
            {
                if (precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], precio[f, c]);
                }
            }
        }
        public void MostrarOrigenes(int c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            for (int f = 0; f < 5; f++)
            {
                if (precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], precio[f, c]);
                }
            }
        }
        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (int i = 0; i < 5; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (int f = 0; f < 5; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (int c = 0; c < 5; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = precio[f, c];
                }
            }

        }
        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }
        public void BorrarTodo()
        {
            for(int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    precio[f, c] = 0;
                }
            }
        }
    }  
}
