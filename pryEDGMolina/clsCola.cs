using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDGMolina
{
    internal class clsCola
    {
        //campos de la cola
        private clsNodos prim;
        private clsNodos ult;   

        //Creamos las propiedades 
        public clsNodos Primero
        {
            get { return prim; }
            set { prim = value; }
        }
        public clsNodos Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodos Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else 
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
    
        }
       // public void Eliminar()
        //{
          //  if (Primero != null)
            //{
              //  Primero = Primero.Siguiente;
            //}
        //}   
        public void eliminar()
        {
                if (Primero == Ultimo)
                {
                    Primero = null;
                    Ultimo = null;
                }
                else
                {
                    Primero = Primero.Siguiente;
                }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodos aux = prim;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Nombre, aux.Codigo, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lista)
        {
            clsNodos aux = prim;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Nombre + aux.Codigo + aux.Tramite);
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
        }
}
