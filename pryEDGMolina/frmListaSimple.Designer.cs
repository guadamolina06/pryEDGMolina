namespace pryEDGMolina
{
    partial class frmListaSimple
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
            this.gpbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbEliminarElemento = new System.Windows.Forms.GroupBox();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbNuevoElemento.SuspendLayout();
            this.gpbEliminarElemento.SuspendLayout();
            this.gpbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNuevoElemento
            // 
            this.gpbNuevoElemento.Controls.Add(this.txtTramite);
            this.gpbNuevoElemento.Controls.Add(this.txtNombre);
            this.gpbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gpbNuevoElemento.Controls.Add(this.txtAgregar);
            this.gpbNuevoElemento.Controls.Add(this.label3);
            this.gpbNuevoElemento.Controls.Add(this.label2);
            this.gpbNuevoElemento.Controls.Add(this.label1);
            this.gpbNuevoElemento.Location = new System.Drawing.Point(359, 15);
            this.gpbNuevoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gpbNuevoElemento.Name = "gpbNuevoElemento";
            this.gpbNuevoElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gpbNuevoElemento.Size = new System.Drawing.Size(267, 250);
            this.gpbNuevoElemento.TabIndex = 0;
            this.gpbNuevoElemento.TabStop = false;
            this.gpbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(128, 160);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(117, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(25, 197);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(220, 46);
            this.txtAgregar.TabIndex = 3;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // gpbEliminarElemento
            // 
            this.gpbEliminarElemento.Controls.Add(this.cmbCodigo);
            this.gpbEliminarElemento.Controls.Add(this.lblCodigo);
            this.gpbEliminarElemento.Controls.Add(this.btnEliminar);
            this.gpbEliminarElemento.Location = new System.Drawing.Point(633, 15);
            this.gpbEliminarElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gpbEliminarElemento.Name = "gpbEliminarElemento";
            this.gpbEliminarElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gpbEliminarElemento.Size = new System.Drawing.Size(267, 250);
            this.gpbEliminarElemento.TabIndex = 1;
            this.gpbEliminarElemento.TabStop = false;
            this.gpbEliminarElemento.Text = "Eliminar Elemento";
            // 
            // gpbListado
            // 
            this.gpbListado.Controls.Add(this.dgvListaSimple);
            this.gpbListado.Controls.Add(this.lstLista);
            this.gpbListado.Location = new System.Drawing.Point(16, 287);
            this.gpbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gpbListado.Size = new System.Drawing.Size(880, 287);
            this.gpbListado.TabIndex = 2;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado en una Lista y Grilla";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(7, 31);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(299, 244);
            this.lstLista.TabIndex = 0;
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(312, 31);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.RowHeadersWidth = 51;
            this.dgvListaSimple.RowTemplate.Height = 24;
            this.dgvListaSimple.Size = new System.Drawing.Size(561, 244);
            this.dgvListaSimple.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(7, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(253, 46);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 166);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(92, 163);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(164, 24);
            this.cmbCodigo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 240);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
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
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbListado);
            this.Controls.Add(this.gpbEliminarElemento);
            this.Controls.Add(this.gpbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaSimple";
            this.Text = "Estructura de Datos Lista Simple";
            this.gpbNuevoElemento.ResumeLayout(false);
            this.gpbNuevoElemento.PerformLayout();
            this.gpbEliminarElemento.ResumeLayout(false);
            this.gpbEliminarElemento.PerformLayout();
            this.gpbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNuevoElemento;
        private System.Windows.Forms.GroupBox gpbEliminarElemento;
        private System.Windows.Forms.GroupBox gpbListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button txtAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}