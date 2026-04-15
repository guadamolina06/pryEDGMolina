namespace pryEDGMolina
{
    partial class frmCola
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
            this.gbxNuevoElemo = new System.Windows.Forms.GroupBox();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.gpvListadoCola = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lbltramiteE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNuevoElemo.SuspendLayout();
            this.gpbElementoEliminado.SuspendLayout();
            this.gpvListadoCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.gbxNuevoElemo.Location = new System.Drawing.Point(291, 15);
            this.gbxNuevoElemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNuevoElemo.Name = "gbxNuevoElemo";
            this.gbxNuevoElemo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNuevoElemo.Size = new System.Drawing.Size(259, 235);
            this.gbxNuevoElemo.TabIndex = 0;
            this.gbxNuevoElemo.TabStop = false;
            this.gbxNuevoElemo.Text = "Nuevo Elemento";
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
            this.gpbElementoEliminado.Location = new System.Drawing.Point(557, 15);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Size = new System.Drawing.Size(259, 235);
            this.gpbElementoEliminado.TabIndex = 1;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // gpvListadoCola
            // 
            this.gpvListadoCola.Controls.Add(this.lstCola);
            this.gpvListadoCola.Controls.Add(this.dgvCola);
            this.gpvListadoCola.Location = new System.Drawing.Point(12, 276);
            this.gpvListadoCola.Name = "gpvListadoCola";
            this.gpvListadoCola.Size = new System.Drawing.Size(804, 273);
            this.gpvListadoCola.TabIndex = 2;
            this.gpvListadoCola.TabStop = false;
            this.gpvListadoCola.Text = "Listado en una Lista y en una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvCola.Location = new System.Drawing.Point(279, 21);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.RowTemplate.Height = 24;
            this.dgvCola.Size = new System.Drawing.Size(519, 245);
            this.dgvCola.TabIndex = 0;
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
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(6, 21);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(267, 244);
            this.lstCola.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(16, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(16, 112);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(58, 18);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(152, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(133, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(133, 112);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(119, 24);
            this.txtTramite.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(41, 169);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(42, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteEliminar.Location = new System.Drawing.Point(17, 112);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(58, 18);
            this.lblTramiteEliminar.TabIndex = 9;
            this.lblTramiteEliminar.Text = "Trámite";
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEliminar.Location = new System.Drawing.Point(17, 74);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(62, 18);
            this.lblNombreEliminar.TabIndex = 8;
            this.lblNombreEliminar.Text = "Nombre";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEliminar.Location = new System.Drawing.Point(17, 34);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(56, 18);
            this.lblCodigoEliminar.TabIndex = 7;
            this.lblCodigoEliminar.Text = "Código";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoE.Location = new System.Drawing.Point(153, 34);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoE.TabIndex = 11;
            this.lblCodigoE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreE
            // 
            this.lblNombreE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreE.Location = new System.Drawing.Point(129, 75);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(124, 23);
            this.lblNombreE.TabIndex = 12;
            this.lblNombreE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltramiteE
            // 
            this.lbltramiteE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltramiteE.Location = new System.Drawing.Point(129, 116);
            this.lbltramiteE.Name = "lbltramiteE";
            this.lbltramiteE.Size = new System.Drawing.Size(124, 23);
            this.lbltramiteE.TabIndex = 13;
            this.lbltramiteE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDGMolina.Properties.Resources.Captura_de_pantalla_2026_04_15_133423;
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpvListadoCola);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gbxNuevoElemo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCola";
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.gbxNuevoElemo.ResumeLayout(false);
            this.gbxNuevoElemo.PerformLayout();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.gpvListadoCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNuevoElemo;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.GroupBox gpvListadoCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lbltramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}