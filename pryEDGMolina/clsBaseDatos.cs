using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryEDGMolina
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string cadenaconexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD.mdb";
        private string cadenaconexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BD.mdb";
        

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaconexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libros";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libros");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libros"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Listar(String tabla,DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaconexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libros";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libros");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libros"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
