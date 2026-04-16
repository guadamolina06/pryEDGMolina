using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDGMolina
{
    internal class clsNodos
    {
        //Campos del nodo
        private string nom;
        private string tram;
        private Int32 cod;
        private clsNodos sig;

        //Se crean las propiedades para cada campo
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Int32 Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Tramite
        {
            get { return tram; }
            set { tram = value; }
        }
        public clsNodos Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
