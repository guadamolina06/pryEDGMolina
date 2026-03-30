using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Se agrega una libreria o espacio de nombre 
namespace pryEDGMolina
{
    internal class clsArchivo
    {
        //Crear un campo
        public string NomArchi ="colores.txt";


        public void Grabar()
        {
            //Abrir archivo para la escritura 
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola");
            AD.Close();

        }
        public void Grabar(string dato)
        {
            //Abrir archivo para la escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(dato);
            AD.Close();

        }


    }
   
  
}
