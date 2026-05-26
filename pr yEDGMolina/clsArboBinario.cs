using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace pryEDGMolina
{
    internal class clsArboBinario
    {
        //Campos del nodo
        private clsNodos PrimerNodo;

        //Se crean las propiedades para cada campo
        public clsNodos Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodos Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodos Ant = Raiz;
                clsNodos Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierda;
                    else Aux = Aux.Derecha;
                }

                if (Nvo.Codigo < Ant.Codigo) Ant.Izquierda = Nvo;
                else Ant.Derecha = Nvo;
            }
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(nodoPadre);
            if (Raiz != null)
            {
                PreOrden(Raiz, nodoPadre);
            }
            tree.ExpandAll();

        }
        private void PreOrden(clsNodos R, TreeNode nodoTreeView)
        {
            if (R == null) return;
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierda != null)
            {
                PreOrden(R.Izquierda, NodoPadre);
            }
            if (R.Derecha != null)
            {
                PreOrden(R.Derecha, NodoPadre);
            }
        }

        // Recorrido InOrden hacia DataGridView (existente) — ahora con chequeo de null
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void InOrdenAsc(DataGridView Dgv, clsNodos R)
        {
            if (R == null) return;
            if (R.Izquierda != null)
            {
                InOrdenAsc(Dgv, R.Izquierda);
            }
            Dgv.Rows.Add(R.Nombre, R.Codigo, R.Tramite);
            if (R.Derecha != null)
            {
                InOrdenAsc(Dgv, R.Derecha);
            }
        }

        // Sobrecarga: InOrden para ComboBox
        public void Recorrer(ComboBox cbo)
        {
            cbo.Items.Clear();
            InOrdenCombo(cbo, Raiz);
        }
        private void InOrdenCombo(ComboBox cbo, clsNodos R)
        {
            if (R == null) return;
            if (R.Izquierda != null)
            {
                InOrdenCombo(cbo, R.Izquierda);
            }
            cbo.Items.Add(R.Nombre);
            if (R.Derecha != null)
            {
                InOrdenCombo(cbo, R.Derecha);
            }
        }

        // Sobrecarga: InOrden que devuelve un vector (array) de nodos en orden
        public clsNodos[] InOrdenToArray()
        {
            List<clsNodos> lista = new List<clsNodos>();
            InOrdenToList(Raiz, lista);
            return lista.ToArray();
        }
        private void InOrdenToList(clsNodos R, List<clsNodos> lista)
        {
            if (R == null) return;
            if (R.Izquierda != null)
            {
                InOrdenToList(R.Izquierda, lista);
            }
            lista.Add(R);
            if (R.Derecha != null)
            {
                InOrdenToList(R.Derecha, lista);
            }
        }

        // Recorridos PreOrden y PostOrden para la grilla (DataGridView)
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        private void PreOrden(DataGridView Dgv, clsNodos R)
        {
            if (R == null) return;
            Dgv.Rows.Add(R.Nombre, R.Codigo, R.Tramite);
            if (R.Izquierda != null)
            {
                PreOrden(Dgv, R.Izquierda);
            }
            if (R.Derecha != null)
            {
                PreOrden(Dgv, R.Derecha);
            }
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void PostOrden(DataGridView Dgv, clsNodos R)
        {
            if (R == null) return;
            if (R.Izquierda != null)
            {
                PostOrden(Dgv, R.Izquierda);
            }
            if (R.Derecha != null)
            {
                PostOrden(Dgv, R.Derecha);
            }
            Dgv.Rows.Add(R.Nombre, R.Codigo, R.Tramite);
        }
    }
}