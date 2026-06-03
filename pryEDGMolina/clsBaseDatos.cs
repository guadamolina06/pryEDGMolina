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
        private string cadenaconexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string cadenaconexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BaseDeDatos\\Libreria (2).mdb";
        

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaconexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libreria";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libreria");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libreria"];

                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show(e.Message);
                
            }
        }
        public void Listar(String tabla,DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaconexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show(e.Message);
            }
        }
        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = cadenaconexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show(e.Message);
            }
        }

    }
}
