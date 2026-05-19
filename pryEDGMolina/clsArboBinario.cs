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

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void InOrdenAsc(DataGridView Dgv, clsNodos R)
        {
            if (R.Izquierda != null) InOrdenAsc(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Nombre, R.Codigo, R.Tramite);
            if (R.Derecha != null) InOrdenAsc(Dgv, R.Derecha);
        }
    }
}
