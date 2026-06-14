using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDGMolina
{
    internal class clsListaSimple
    {
        private clsNodos pri;

        public clsNodos Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodos nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                if (nuevo.Codigo < Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
                }
                else
                {
                    clsNodos aux = Primero;
                    clsNodos ant = Primero;
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodos aux1 = Primero;
                clsNodos aux2 = Primero;
                while (aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
            }
        }
        public void Recorrer(DataGridView dgvDatos)
        {
            clsNodos aux = Primero;
            dgvDatos.Rows.Clear();
            while (aux != null)
            {
                dgvDatos.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lstDatos)
        {
            clsNodos aux = Primero;
            lstDatos.Items.Clear();
            while (aux != null)
            {
                lstDatos.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox cmbDatos)
        {
            clsNodos aux = Primero;
            cmbDatos.Items.Clear();
            while (aux != null)
            {
                cmbDatos.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(String NombreArchivo)
        {
            clsNodos aux = Primero;
            StreamWriter AD = new StreamWriter("pila.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
        public void Recorrer()
        {
            clsNodos aux = Primero;
            StreamWriter AD = new StreamWriter("pila.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
