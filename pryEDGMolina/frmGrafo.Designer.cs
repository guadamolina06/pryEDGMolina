namespace pryEDGMolina
{
    partial class frmGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbxCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblPrecioR = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gpbListarViaje = new System.Windows.Forms.GroupBox();
            this.llblDesde = new System.Windows.Forms.Label();
            this.cmbListarDestino = new System.Windows.Forms.ComboBox();
            this.btnListarDestino = new System.Windows.Forms.Button();
            this.btnhasta = new System.Windows.Forms.Label();
            this.cmbhasta = new System.Windows.Forms.ComboBox();
            this.btnlistarorigenes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbConsultaDatos.SuspendLayout();
            this.gbxCargaDatos.SuspendLayout();
            this.gpbListarViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gpbConsultaDatos.Controls.Add(this.comboBox1);
            this.gpbConsultaDatos.Controls.Add(this.label3);
            this.gpbConsultaDatos.Controls.Add(this.label4);
            this.gpbConsultaDatos.Controls.Add(this.label2);
            this.gpbConsultaDatos.Controls.Add(this.ComboBox);
            this.gpbConsultaDatos.Controls.Add(this.label1);
            this.gpbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(565, 17);
            this.gpbConsultaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbConsultaDatos.Size = new System.Drawing.Size(277, 201);
            this.gpbConsultaDatos.TabIndex = 9;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta De Datos:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Sant Fe",
            "Buenos Aires",
            "Salta"});
            this.comboBox1.Location = new System.Drawing.Point(112, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(112, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destino:";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Sant Fe",
            "Buenos Aires",
            "Salta"});
            this.ComboBox.Location = new System.Drawing.Point(112, 34);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(147, 24);
            this.ComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(7, 150);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 39);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // gbxCargaDatos
            // 
            this.gbxCargaDatos.Controls.Add(this.btnCargar);
            this.gbxCargaDatos.Controls.Add(this.lblPrecioR);
            this.gbxCargaDatos.Controls.Add(this.cmbOrigen);
            this.gbxCargaDatos.Controls.Add(this.cmbDestino);
            this.gbxCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbxCargaDatos.Controls.Add(this.lblPrecio);
            this.gbxCargaDatos.Controls.Add(this.lblDestino);
            this.gbxCargaDatos.Controls.Add(this.lblOrigen);
            this.gbxCargaDatos.Location = new System.Drawing.Point(299, 15);
            this.gbxCargaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCargaDatos.Name = "gbxCargaDatos";
            this.gbxCargaDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCargaDatos.Size = new System.Drawing.Size(259, 202);
            this.gbxCargaDatos.TabIndex = 8;
            this.gbxCargaDatos.TabStop = false;
            this.gbxCargaDatos.Text = "Cargar de Datos:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(143, 150);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 40);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioR
            // 
            this.lblPrecioR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioR.Location = new System.Drawing.Point(104, 112);
            this.lblPrecioR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioR.Name = "lblPrecioR";
            this.lblPrecioR.Size = new System.Drawing.Size(147, 27);
            this.lblPrecioR.TabIndex = 9;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Sant Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbOrigen.Location = new System.Drawing.Point(104, 37);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(145, 24);
            this.cmbOrigen.TabIndex = 8;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Sant Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDestino.Location = new System.Drawing.Point(104, 74);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(145, 24);
            this.cmbDestino.TabIndex = 7;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(7, 150);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(108, 39);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(16, 112);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(16, 74);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(63, 18);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(16, 34);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(149, 150);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 39);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // gpbListarViaje
            // 
            this.gpbListarViaje.Controls.Add(this.dataGridView1);
            this.gpbListarViaje.Controls.Add(this.button2);
            this.gpbListarViaje.Controls.Add(this.btnlistarorigenes);
            this.gpbListarViaje.Controls.Add(this.cmbhasta);
            this.gpbListarViaje.Controls.Add(this.btnhasta);
            this.gpbListarViaje.Controls.Add(this.btnListarDestino);
            this.gpbListarViaje.Controls.Add(this.cmbListarDestino);
            this.gpbListarViaje.Controls.Add(this.llblDesde);
            this.gpbListarViaje.Location = new System.Drawing.Point(16, 225);
            this.gpbListarViaje.Name = "gpbListarViaje";
            this.gpbListarViaje.Size = new System.Drawing.Size(826, 317);
            this.gpbListarViaje.TabIndex = 10;
            this.gpbListarViaje.TabStop = false;
            this.gpbListarViaje.Text = "Listar Viaje...";
            // 
            // llblDesde
            // 
            this.llblDesde.AutoSize = true;
            this.llblDesde.Location = new System.Drawing.Point(20, 32);
            this.llblDesde.Name = "llblDesde";
            this.llblDesde.Size = new System.Drawing.Size(51, 16);
            this.llblDesde.TabIndex = 0;
            this.llblDesde.Text = "Desde:";
            // 
            // cmbListarDestino
            // 
            this.cmbListarDestino.FormattingEnabled = true;
            this.cmbListarDestino.Location = new System.Drawing.Point(77, 29);
            this.cmbListarDestino.Name = "cmbListarDestino";
            this.cmbListarDestino.Size = new System.Drawing.Size(121, 24);
            this.cmbListarDestino.TabIndex = 1;
            // 
            // btnListarDestino
            // 
            this.btnListarDestino.Location = new System.Drawing.Point(221, 29);
            this.btnListarDestino.Name = "btnListarDestino";
            this.btnListarDestino.Size = new System.Drawing.Size(110, 24);
            this.btnListarDestino.TabIndex = 2;
            this.btnListarDestino.Text = "Listar Destinos";
            this.btnListarDestino.UseVisualStyleBackColor = true;
            // 
            // btnhasta
            // 
            this.btnhasta.AutoSize = true;
            this.btnhasta.Location = new System.Drawing.Point(365, 32);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(46, 16);
            this.btnhasta.TabIndex = 3;
            this.btnhasta.Text = "Hasta:";
            // 
            // cmbhasta
            // 
            this.cmbhasta.FormattingEnabled = true;
            this.cmbhasta.Location = new System.Drawing.Point(426, 29);
            this.cmbhasta.Name = "cmbhasta";
            this.cmbhasta.Size = new System.Drawing.Size(121, 24);
            this.cmbhasta.TabIndex = 4;
            // 
            // btnlistarorigenes
            // 
            this.btnlistarorigenes.Location = new System.Drawing.Point(567, 28);
            this.btnlistarorigenes.Name = "btnlistarorigenes";
            this.btnlistarorigenes.Size = new System.Drawing.Size(110, 24);
            this.btnlistarorigenes.TabIndex = 5;
            this.btnlistarorigenes.Text = "Listar Origenes";
            this.btnlistarorigenes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ver todos los viajes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 254);
            this.dataGridView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDGMolina.Properties.Resources.Captura_de_pantalla_2026_06_03_110045;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.gpbListarViaje);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Controls.Add(this.gbxCargaDatos);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            this.gbxCargaDatos.ResumeLayout(false);
            this.gbxCargaDatos.PerformLayout();
            this.gpbListarViaje.ResumeLayout(false);
            this.gpbListarViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbxCargaDatos;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblPrecioR;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gpbListarViaje;
        private System.Windows.Forms.ComboBox cmbhasta;
        private System.Windows.Forms.Label btnhasta;
        private System.Windows.Forms.Button btnListarDestino;
        private System.Windows.Forms.ComboBox cmbListarDestino;
        private System.Windows.Forms.Label llblDesde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlistarorigenes;
    }
}