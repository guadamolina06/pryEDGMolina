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
    public partial class opBasedeDatos : Form
    {
        private clsBaseDatos objBaseDatos = new clsBaseDatos();

        public opBasedeDatos()
        {
            InitializeComponent();

            this.btnproyeccionsimple.Click += new EventHandler(btnproyeccionsimple_Click);
            this.btnproyeccionmultiatributo.Click += new EventHandler(btnproyeccionmultiatributo_Click);
            this.btnJuntar.Click += new EventHandler(btnJuntar_Click);

            this.btnSeleccionsimple.Click += new EventHandler(btnSeleccionsimple_Click);
            this.btnseleccionmultiatrubuto.Click += new EventHandler(btnseleccionmultiatrubuto_Click);
            this.btnseleccionconvulcion.Click += new EventHandler(btnseleccionconvulcion_Click);

            this.btnUnion.Click += new EventHandler(btnUnion_Click);
            this.btnInterseccion.Click += new EventHandler(btnInterseccion_Click);
            this.btnDiferencia.Click += new EventHandler(btnDiferencia_Click);
        }

        // ---------------------------------------------------------------
        // OPERACIONES DE PROYECCIÓN - SELECT
        // ---------------------------------------------------------------

        // SELECT de un solo atributo (columna) de la tabla Libro
        private void btnproyeccionsimple_Click(object sender, EventArgs e)
        {
            string columna = Interaction.InputBox(
                "Ingrese el nombre del atributo (columna) a proyectar:\n" +
                "Ejemplos: Titulo, Año, Precio, Cantidad",
                "Proyección simple", "Titulo");

            if (string.IsNullOrWhiteSpace(columna))
                return;

            string sql = "SELECT [" + columna.Trim() + "] FROM Libro";
            objBaseDatos.Listar(dgvDatos, sql);
        }

        // SELECT de varios atributos (columnas), separados por coma
        private void btnproyeccionmultiatributo_Click(object sender, EventArgs e)
        {
            string columnas = Interaction.InputBox(
                "Ingrese los atributos (columnas) a proyectar, separados por coma:\n" +
                "Ejemplo: Titulo, Año, Precio",
                "Proyección multiatributo", "Titulo, Año, Precio");

            if (string.IsNullOrWhiteSpace(columnas))
                return;

            string[] partes = columnas.Split(',');
            for (int i = 0; i < partes.Length; i++)
            {
                partes[i] = "[" + partes[i].Trim() + "]";
            }

            string sql = "SELECT " + string.Join(", ", partes) + " FROM Libro";
            objBaseDatos.Listar(dgvDatos, sql);
        }

        // "Juntar" (JOIN): combina Libro con Autor, Pais e Idioma
        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT Libro.Titulo, Autor.Nombre AS Autor, Pais.Nombre AS Pais, " +
                "Idioma.Nombre AS Idioma, Libro.[Año], Libro.Cantidad, Libro.Precio " +
                "FROM ((Libro " +
                "INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor) " +
                "INNER JOIN Pais ON Libro.IdPais = Pais.IdPais) " +
                "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // ---------------------------------------------------------------
        // OPERACIONES DE SELECCIÓN - WHERE
        // ---------------------------------------------------------------

        // WHERE con una sola condición: columna = valor
        private void btnSeleccionsimple_Click(object sender, EventArgs e)
        {
            string columna = Interaction.InputBox(
                "Ingrese la columna para la condición:\n" +
                "Ejemplos: IdIdioma, IdPais, IdAutor, Cantidad",
                "Selección simple - Columna", "IdIdioma");

            if (string.IsNullOrWhiteSpace(columna))
                return;

            string valor = Interaction.InputBox(
                "Ingrese el valor que debe tener [" + columna + "]:",
                "Selección simple - Valor", "");

            if (valor == null)
                return;

            string sql = "SELECT * FROM Libro WHERE [" + columna.Trim() + "] = " + FormatearValor(columna, valor);
            objBaseDatos.Listar(dgvDatos, sql);
        }

        // WHERE con dos condiciones combinadas con AND
        private void btnseleccionmultiatrubuto_Click(object sender, EventArgs e)
        {
            string col1 = Interaction.InputBox(
                "Ingrese la primera columna para la condición:\nEjemplo: IdIdioma", "Selección multiatributo - Columna 1", "IdIdioma");
            if (string.IsNullOrWhiteSpace(col1)) return;

            string val1 = Interaction.InputBox(
                "Ingrese el valor para [" + col1 + "]:", "Selección multiatributo - Valor 1", "");
            if (val1 == null) return;

            string col2 = Interaction.InputBox(
                "Ingrese la segunda columna para la condición:\nEjemplo: IdPais", "Selección multiatributo - Columna 2", "IdPais");
            if (string.IsNullOrWhiteSpace(col2)) return;

            string val2 = Interaction.InputBox(
                "Ingrese el valor para [" + col2 + "]:", "Selección multiatributo - Valor 2", "");
            if (val2 == null) return;

            string sql = "SELECT * FROM Libro WHERE [" + col1.Trim() + "] = " + FormatearValor(col1, val1) +
                         " AND [" + col2.Trim() + "] = " + FormatearValor(col2, val2);

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // "Selección por convulción" (subconsulta): libros con precio mayor al promedio
        private void btnseleccionconvulcion_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT * FROM Libro " +
                "WHERE Precio > (SELECT AVG(Precio) FROM Libro)";

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // ---------------------------------------------------------------
        // OPERACIONES ALGEBRAICAS (UNION, INTERSECCIÓN, DIFERENCIA)
        // ---------------------------------------------------------------

        // UNIÓN: títulos de libros con precio mayor a 700 UNIDOS con los de cantidad mayor a 8
        private void btnUnion_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT Titulo, Precio, Cantidad FROM Libro WHERE Precio > 700 " +
                "UNION " +
                "SELECT Titulo, Precio, Cantidad FROM Libro WHERE Cantidad > 8";

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // INTERSECCIÓN: libros con precio mayor a 700 Y, a la vez, cantidad mayor a 5
        // (Jet/ACE no soporta INTERSECT, se emula con IN ... AND IN ...)
        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT * FROM Libro " +
                "WHERE IdLibro IN (SELECT IdLibro FROM Libro WHERE Precio > 700) " +
                "AND IdLibro IN (SELECT IdLibro FROM Libro WHERE Cantidad > 5)";

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // DIFERENCIA: libros con precio mayor a 700 que NO tengan cantidad mayor a 5
        // (Jet/ACE no soporta EXCEPT, se emula con IN ... AND NOT IN ...)
        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT * FROM Libro " +
                "WHERE IdLibro IN (SELECT IdLibro FROM Libro WHERE Precio > 700) " +
                "AND IdLibro NOT IN (SELECT IdLibro FROM Libro WHERE Cantidad > 5)";

            objBaseDatos.Listar(dgvDatos, sql);
        }

        // ---------------------------------------------------------------
        // Utilidad: formatea el valor según el tipo de columna
        // (las columnas de texto requieren comillas simples en SQL)
        // ---------------------------------------------------------------
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

            // Si no es numérico, se trata como texto (por las dudas)
            double numero;
            if (!double.TryParse(valor, out numero))
            {
                return "'" + valor.Replace("'", "''") + "'";
            }

            return valor;
        }
    }
}