namespace pryEDGMolina
{
    partial class opBasedeDatos
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpvopproyeccion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnproyeccionsimple = new System.Windows.Forms.Button();
            this.btnproyeccionmultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnseleccionconvulcion = new System.Windows.Forms.Button();
            this.btnseleccionmultiatrubuto = new System.Windows.Forms.Button();
            this.btnSeleccionsimple = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpvopproyeccion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(776, 280);
            this.dgvDatos.TabIndex = 0;
            // 
            // gpvopproyeccion
            // 
            this.gpvopproyeccion.Controls.Add(this.btnJuntar);
            this.gpvopproyeccion.Controls.Add(this.btnproyeccionmultiatributo);
            this.gpvopproyeccion.Controls.Add(this.btnproyeccionsimple);
            this.gpvopproyeccion.Location = new System.Drawing.Point(12, 298);
            this.gpvopproyeccion.Name = "gpvopproyeccion";
            this.gpvopproyeccion.Size = new System.Drawing.Size(257, 127);
            this.gpvopproyeccion.TabIndex = 1;
            this.gpvopproyeccion.TabStop = false;
            this.gpvopproyeccion.Text = "Operaciones de Proyección- SELECT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnseleccionconvulcion);
            this.groupBox2.Controls.Add(this.btnseleccionmultiatrubuto);
            this.groupBox2.Controls.Add(this.btnSeleccionsimple);
            this.groupBox2.Location = new System.Drawing.Point(275, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Location = new System.Drawing.Point(535, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnproyeccionsimple
            // 
            this.btnproyeccionsimple.Location = new System.Drawing.Point(6, 32);
            this.btnproyeccionsimple.Name = "btnproyeccionsimple";
            this.btnproyeccionsimple.Size = new System.Drawing.Size(245, 24);
            this.btnproyeccionsimple.TabIndex = 0;
            this.btnproyeccionsimple.Text = "Proyección simple";
            this.btnproyeccionsimple.UseVisualStyleBackColor = true;
            // 
            // btnproyeccionmultiatributo
            // 
            this.btnproyeccionmultiatributo.Location = new System.Drawing.Point(6, 62);
            this.btnproyeccionmultiatributo.Name = "btnproyeccionmultiatributo";
            this.btnproyeccionmultiatributo.Size = new System.Drawing.Size(245, 24);
            this.btnproyeccionmultiatributo.TabIndex = 1;
            this.btnproyeccionmultiatributo.Text = "Proyección multiatributo";
            this.btnproyeccionmultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 92);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(245, 24);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnseleccionconvulcion
            // 
            this.btnseleccionconvulcion.Location = new System.Drawing.Point(3, 92);
            this.btnseleccionconvulcion.Name = "btnseleccionconvulcion";
            this.btnseleccionconvulcion.Size = new System.Drawing.Size(245, 24);
            this.btnseleccionconvulcion.TabIndex = 5;
            this.btnseleccionconvulcion.Text = "Selección por convulción";
            this.btnseleccionconvulcion.UseVisualStyleBackColor = true;
            // 
            // btnseleccionmultiatrubuto
            // 
            this.btnseleccionmultiatrubuto.Location = new System.Drawing.Point(3, 62);
            this.btnseleccionmultiatrubuto.Name = "btnseleccionmultiatrubuto";
            this.btnseleccionmultiatrubuto.Size = new System.Drawing.Size(245, 24);
            this.btnseleccionmultiatrubuto.TabIndex = 4;
            this.btnseleccionmultiatrubuto.Text = "Selección multiatrubuto";
            this.btnseleccionmultiatrubuto.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionsimple
            // 
            this.btnSeleccionsimple.Location = new System.Drawing.Point(3, 32);
            this.btnSeleccionsimple.Name = "btnSeleccionsimple";
            this.btnSeleccionsimple.Size = new System.Drawing.Size(245, 24);
            this.btnSeleccionsimple.TabIndex = 3;
            this.btnSeleccionsimple.Text = "Selección simple";
            this.btnSeleccionsimple.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(2, 92);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(245, 24);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(2, 62);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(245, 24);
            this.btnInterseccion.TabIndex = 7;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(2, 32);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(245, 24);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // opBasedeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpvopproyeccion);
            this.Controls.Add(this.dgvDatos);
            this.Name = "opBasedeDatos";
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpvopproyeccion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpvopproyeccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnproyeccionmultiatributo;
        private System.Windows.Forms.Button btnproyeccionsimple;
        private System.Windows.Forms.Button btnseleccionconvulcion;
        private System.Windows.Forms.Button btnseleccionmultiatrubuto;
        private System.Windows.Forms.Button btnSeleccionsimple;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
    }
}