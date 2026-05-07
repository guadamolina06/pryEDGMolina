using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDGMolina
{
    internal class clsListaDoble
    {
        //Campos
        private clsNodos pri;
        private clsNodos ult;
        //propiedades
        public clsNodos Primero 
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodos Ultimo 
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodos Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo; 
            }
            else 
            {
                if (Nvo.Codigo > Ultimo.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else 
                {
                    clsNodos Aux = Primero;
                    clsNodos Ant = Primero;
                    while (Aux.Codigo < Nvo.Codigo) 
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }
                    Ant.Siguiente = Nvo;
                    Nvo.Siguiente= Aux;
                    Aux.Anterior = Nvo;
                    Nvo.Anterior = Ant;
                }
            }
        }
        public void Recorrer(ListBox Lista) 
        {
          
            clsNodos aux = Primero;
            Lista.Items.Clear();
            while (aux != null) 
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        
        }
        public void Recorrer(String NombreArchivo) 
        {
            clsNodos aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de personas ordenada por codigo\n");
            AD.WriteLine("Codigo; NOmbre; Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Tramite);
                aux=aux.Siguiente; 
            }
            AD.Close();
 
        }

        public void Recorrer(ComboBox Combo) 
        {
            clsNodos aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            clsNodos aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null) 
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero) 
            {
                Primero = null;
                Ultimo = null;
               
            }
            else 
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else 
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;

                    }
                    else 
                    {

                        clsNodos aux = Primero;
                        clsNodos ant = Primero;
                        while (aux.Codigo < Codigo) 
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        
                        }
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                        ant.Siguiente = aux;

                    }
                }
            }
        }
    }
}
