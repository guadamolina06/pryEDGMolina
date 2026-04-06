using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////
using System.IO;
using System.Windows.Forms;
//Se agrega una libreria o espacio de nombre 
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
            AD.WriteLine();
            AD.Close();

        }
        public void Grabar(string dato)
        {
            //Abrir archivo para la escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(dato);
            AD.Close();

        }
        public void Recorrer (ComboBox cmbDatos)
        {
          cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();

        }
        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }


    }
   
  
}
