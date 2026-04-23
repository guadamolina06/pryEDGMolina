namespace pryEDGMolina
{
    partial class frmPila
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpvListadoCola = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lbltramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.gbxNuevoElemo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpvListadoCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.gpbElementoEliminado.SuspendLayout();
            this.gbxNuevoElemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDGMolina.Properties.Resources.Captura_de_pantalla_2026_04_15_133423;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gpvListadoCola
            // 
            this.gpvListadoCola.Controls.Add(this.lstPila);
            this.gpvListadoCola.Controls.Add(this.dgvPila);
            this.gpvListadoCola.Location = new System.Drawing.Point(11, 217);
            this.gpvListadoCola.Margin = new System.Windows.Forms.Padding(2);
            this.gpvListadoCola.Name = "gpvListadoCola";
            this.gpvListadoCola.Padding = new System.Windows.Forms.Padding(2);
            this.gpvListadoCola.Size = new System.Drawing.Size(603, 222);
            this.gpvListadoCola.TabIndex = 6;
            this.gpvListadoCola.TabStop = false;
            this.gpvListadoCola.Text = "Listado en una Lista y en una Grilla";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(4, 17);
            this.lstPila.Margin = new System.Windows.Forms.Padding(2);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(201, 199);
            this.lstPila.TabIndex = 1;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvPila.Location = new System.Drawing.Point(209, 17);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.RowTemplate.Height = 24;
            this.dgvPila.Size = new System.Drawing.Size(389, 199);
            this.dgvPila.TabIndex = 0;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Cólumna";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 125;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.MinimumWidth = 6;
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.Width = 125;
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.lbltramiteE);
            this.gpbElementoEliminado.Controls.Add(this.lblNombreE);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoE);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblTramiteEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblNombreEliminar);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(416, 11);
            this.gpbElementoEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Padding = new System.Windows.Forms.Padding(2);
            this.gpbElementoEliminado.Size = new System.Drawing.Size(194, 191);
            this.gpbElementoEliminado.TabIndex = 5;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lbltramiteE
            // 
            this.lbltramiteE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltramiteE.Location = new System.Drawing.Point(97, 94);
            this.lbltramiteE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltramiteE.Name = "lbltramiteE";
            this.lbltramiteE.Size = new System.Drawing.Size(93, 19);
            this.lbltramiteE.TabIndex = 13;
            this.lbltramiteE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreE
            // 
            this.lblNombreE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreE.Location = new System.Drawing.Point(97, 61);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(93, 19);
            this.lblNombreE.TabIndex = 12;
            this.lblNombreE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoE.Location = new System.Drawing.Point(115, 28);
            this.lblCodigoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(75, 19);
            this.lblCodigoE.TabIndex = 11;
            this.lblCodigoE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(32, 137);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteEliminar.Location = new System.Drawing.Point(13, 91);
            this.lblTramiteEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(49, 15);
            this.lblTramiteEliminar.TabIndex = 9;
            this.lblTramiteEliminar.Text = "Trámite";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEliminar.Location = new System.Drawing.Point(13, 28);
            this.lblCodigoEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(46, 15);
            this.lblCodigoEliminar.TabIndex = 7;
            this.lblCodigoEliminar.Text = "Código";
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEliminar.Location = new System.Drawing.Point(13, 60);
            this.lblNombreEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(52, 15);
            this.lblNombreEliminar.TabIndex = 8;
            this.lblNombreEliminar.Text = "Nombre";
            // 
            // gbxNuevoElemo
            // 
            this.gbxNuevoElemo.Controls.Add(this.btnAgregar);
            this.gbxNuevoElemo.Controls.Add(this.txtTramite);
            this.gbxNuevoElemo.Controls.Add(this.txtNombre);
            this.gbxNuevoElemo.Controls.Add(this.txtCodigo);
            this.gbxNuevoElemo.Controls.Add(this.lblTramite);
            this.gbxNuevoElemo.Controls.Add(this.lblNombre);
            this.gbxNuevoElemo.Controls.Add(this.lblCodigo);
            this.gbxNuevoElemo.Location = new System.Drawing.Point(217, 8);
            this.gbxNuevoElemo.Name = "gbxNuevoElemo";
            this.gbxNuevoElemo.Size = new System.Drawing.Size(194, 191);
            this.gbxNuevoElemo.TabIndex = 4;
            this.gbxNuevoElemo.TabStop = false;
            this.gbxNuevoElemo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(31, 137);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(99, 94);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(90, 21);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(100, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(90, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(114, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(12, 91);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(49, 15);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 60);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpvListadoCola);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gbxNuevoElemo);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpvListadoCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.gbxNuevoElemo.ResumeLayout(false);
            this.gbxNuevoElemo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpvListadoCola;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.Label lbltramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.GroupBox gbxNuevoElemo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}