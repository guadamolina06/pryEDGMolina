using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryEDGMolina
{
    internal class clsPila
    {
        private clsNodos prim;

        public clsNodos Primero
        {
            get { return prim; }
            set { prim = value; }
        }
        public void Agregar(clsNodos Nuevo)
        {

            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {

            if (Primero != null)
            {

                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            clsNodos aux = prim;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Nombre + " " + aux.Codigo + " " + aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void Recorrer (DataGridView Grilla)
        {
            clsNodos aux = prim;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Nombre, aux.Codigo, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodos aux = prim;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nomnbre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(",");
                AD.Write(aux.Nombre);
                AD.Write(",");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
        public void Recorrer(ComboBox combo)
        {
            clsNodos aux = prim;
            combo.Items.Clear();
            while (aux != null)
            { 
             combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
