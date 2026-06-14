using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pryEDGMolina
{
    public partial class frmConsultasConOperaciones : Form
    {
        private clsBaseDatos objBaseDatos = new clsBaseDatos();

        public frmConsultasConOperaciones()
        {
            InitializeComponent();

            // Cargar las operaciones disponibles en el combo
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[]
            {
                "Proyección simple",
                "Proyección multiatributo",
                "Juntar (Join)",
                "Selección simple",
                "Selección multiatributo",
                "Selección por convulción (subconsulta)",
                "Unión",
                "Intersección",
                "Diferencia"
            });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            this.btnListar.Click += new EventHandler(btnListar_Click);

            label2.Text = "Seleccione una operación y presione \"Listar\".";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Proyección simple":
                    label2.Text = "Muestra una sola columna de la tabla Libro.\n" +
                                   "Se le pedirá el nombre de la columna a proyectar.";
                    break;

                case "Proyección multiatributo":
                    label2.Text = "Muestra varias columnas de la tabla Libro.\n" +
                                   "Se le pedirán los nombres de las columnas separados por coma.";
                    break;

                case "Juntar (Join)":
                    label2.Text = "Combina la tabla Libro con Autor, Pais e Idioma\n" +
                                   "mostrando los nombres en lugar de los códigos.";
                    break;

                case "Selección simple":
                    label2.Text = "Filtra los libros según una condición (columna = valor).\n" +
                                   "Se le pedirá la columna y el valor.";
                    break;

                case "Selección multiatributo":
                    label2.Text = "Filtra los libros según dos condiciones combinadas con AND.\n" +
                                   "Se le pedirán dos pares de columna/valor.";
                    break;

                case "Selección por convulción (subconsulta)":
                    label2.Text = "Muestra los libros cuyo precio es mayor al precio promedio\n" +
                                   "de todos los libros (subconsulta).";
                    break;

                case "Unión":
                    label2.Text = "Une los títulos de libros con precio mayor a 700\n" +
                                   "con los títulos de libros con cantidad mayor a 8.";
                    break;

                case "Intersección":
                    label2.Text = "Muestra los libros que cumplen a la vez:\n" +
                                   "precio mayor a 700 Y cantidad mayor a 5.";
                    break;

                case "Diferencia":
                    label2.Text = "Muestra los libros con precio mayor a 700\n" +
                                   "que NO tengan cantidad mayor a 5.";
                    break;

                default:
                    label2.Text = "Seleccione una operación y presione \"Listar\".";
                    break;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione primero una operación.");
                return;
            }

            string sql;

            switch (comboBox1.Text)
            {
                case "Proyección simple":
                    sql = ConsultaProyeccionSimple();
                    break;

                case "Proyección multiatributo":
                    sql = ConsultaProyeccionMultiatributo();
                    break;

                case "Juntar (Join)":
                    sql = ConsultaJuntar();
                    break;

                case "Selección simple":
                    sql = ConsultaSeleccionSimple();
                    break;

                case "Selección multiatributo":
                    sql = ConsultaSeleccionMultiatributo();
                    break;

                case "Selección por convulción (subconsulta)":
                    sql = ConsultaSeleccionPorConvulcion();
                    break;

                case "Unión":
                    sql = ConsultaUnion();
                    break;

                case "Intersección":
                    sql = ConsultaInterseccion();
                    break;

                case "Diferencia":
                    sql = ConsultaDiferencia();
                    break;

                default:
                    sql = null;
                    break;
            }

            // Si el usuario canceló algún InputBox, sql queda en null y no se ejecuta nada
            if (string.IsNullOrWhiteSpace(sql))
                return;

            objBaseDatos.Listar(dataGridView1, sql);
        }

        // ---------------------------------------------------------------
        // CONSTRUCCIÓN DE CONSULTAS
        // ---------------------------------------------------------------

        private string ConsultaProyeccionSimple()
        {
            string columna = Interaction.InputBox(
                "Ingrese el nombre del atributo (columna) a proyectar:\n" +
                "Ejemplos: Titulo, Año, Precio, Cantidad",
                "Proyección simple", "Titulo");

            if (string.IsNullOrWhiteSpace(columna))
                return null;

            return "SELECT [" + columna.Trim() + "] FROM Libro";
        }

        private string ConsultaProyeccionMultiatributo()
        {
            string columnas = Interaction.InputBox(
                "Ingrese los atributos (columnas) a proyectar, separados por coma:\n" +
                "Ejemplo: Titulo, Año, Precio",
                "Proyección multiatributo", "Titulo, Año, Precio");

            if (string.IsNullOrWhiteSpace(columnas))
                return null;

            string[] partes = columnas.Split(',');
            for (int i = 0; i < partes.Length; i++)
            {
                partes[i] = "[" + partes[i].Trim() + "]";
            }

            return "SELECT " + string.Join(", ", partes) + " FROM Libro";
        }

        private string ConsultaJuntar()
        {
            return
                "SELECT Libro.Titulo, Autor.Nombre AS Autor, Pais.Nombre AS Pais, " +
                "Idioma.Nombre AS Idioma, Libro.[Año], Libro.Cantidad, Libro.Precio " +
                "FROM ((Libro " +
                "INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor) " +
                "INNER JOIN Pais ON Libro.IdPais = Pais.IdPais) " +
                "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";
        }

        private string ConsultaSeleccionSimple()
        {
            string columna = Interaction.InputBox(
                "Ingrese la columna para la condición:\n" +
                "Ejemplos: IdIdioma, IdPais, IdAutor, Cantidad",
                "Selección simple - Columna", "IdIdioma");

            if (string.IsNullOrWhiteSpace(columna))
                return null;

            string valor = Interaction.InputBox(
                "Ingrese el valor que debe tener [" + columna + "]:",
                "Selección simple - Valor", "");

            if (valor == null)
                return null;

            return "SELECT * FROM Libro WHERE [" + columna.Trim() + "] = " + FormatearValor(columna, valor);
        }

        private string ConsultaSeleccionMultiatributo()
        {
            string col1 = Interaction.InputBox(
                "Ingrese la primera columna para la condición:\nEjemplo: IdIdioma", "Selección multiatributo - Columna 1", "IdIdioma");
            if (string.IsNullOrWhiteSpace(col1)) return null;

            string val1 = Interaction.InputBox(
                "Ingrese el valor para [" + col1 + "]:", "Selección multiatributo - Valor 1", "");
            if (val1 == null) return null;

            string col2 = Interaction.InputBox(
                "Ingrese la segunda columna para la condición:\nEjemplo: IdPais", "Selección multiatributo - Columna 2", "IdPais");
            if (string.IsNullOrWhiteSpace(col2)) return null;

            string val2 = Interaction.InputBox(
                "Ingrese el valor para [" + col2 + "]:", "Selección multiatributo - Valor 2", "");
            if (val2 == null) return null;

            return "SELECT * FROM Libro WHERE [" + col1.Trim() + "] = " + FormatearValor(col1, val1) +
                   " AND [" + col2.Trim() + "] = " + FormatearValor(col2, val2);
        }

        private string ConsultaSeleccionPorConvulcion()
        {
            return "SELECT * FROM Libro WHERE Precio > (SELECT AVG(Precio) FROM Libro)";
        }

        private string ConsultaUnion()
        {
            return
                "SELECT Titulo, Precio, Cantidad FROM Libro WHERE Precio > 700 " +
                "UNION " +
                "SELECT Titulo, Precio, Cantidad FROM Libro WHERE Cantidad > 8";
        }

        private string ConsultaInterseccion()
        {
            return
                "SELECT * FROM Libro " +
                "WHERE IdLibro IN (SELECT IdLibro FROM Libro WHERE Precio > 700) " +
                "AND IdLibro IN (SELECT IdLibro FROM Libro WHERE Cantidad > 5)";
        }

        private string ConsultaDiferencia()
        {
            return
                "SELECT * FROM Libro " +
                "WHERE IdLibro IN (SELECT IdLibro FROM Libro WHERE Precio > 700) " +
                "AND IdLibro NOT IN (SELECT IdLibro FROM Libro WHERE Cantidad > 5)";
        }

        private string FormatearValor(string columna, string valor)
        {
            string[] columnasTexto = { "Titulo", "Año" };

            valor = valor.Trim();

            foreach (string col in columnasTexto)
            {
                if (string.Equals(columna.Trim(), col, StringComparison.OrdinalIgnoreCase))
                {
                    return "'" + valor.Replace("'", "''") + "'";
                }
            }

            double numero;
            if (!double.TryParse(valor, out numero))
            {
                return "'" + valor.Replace("'", "''") + "'";
            }

            return valor;
        }
    }
}
