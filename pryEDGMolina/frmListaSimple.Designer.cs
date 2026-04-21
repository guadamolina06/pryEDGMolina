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
            this.gpbEliminarElemento = new System.Windows.Forms.GroupBox();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gpbNuevoElemento
            // 
            this.gpbNuevoElemento.Location = new System.Drawing.Point(269, 12);
            this.gpbNuevoElemento.Name = "gpbNuevoElemento";
            this.gpbNuevoElemento.Size = new System.Drawing.Size(200, 203);
            this.gpbNuevoElemento.TabIndex = 0;
            this.gpbNuevoElemento.TabStop = false;
            this.gpbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // gpbEliminarElemento
            // 
            this.gpbEliminarElemento.Location = new System.Drawing.Point(475, 12);
            this.gpbEliminarElemento.Name = "gpbEliminarElemento";
            this.gpbEliminarElemento.Size = new System.Drawing.Size(200, 203);
            this.gpbEliminarElemento.TabIndex = 1;
            this.gpbEliminarElemento.TabStop = false;
            this.gpbEliminarElemento.Text = "Eliminar Elemento";
            // 
            // gpbListado
            // 
            this.gpbListado.Location = new System.Drawing.Point(12, 233);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Size = new System.Drawing.Size(660, 233);
            this.gpbListado.TabIndex = 2;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado en una Lista y Grilla";
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 478);
            this.Controls.Add(this.gpbListado);
            this.Controls.Add(this.gpbEliminarElemento);
            this.Controls.Add(this.gpbNuevoElemento);
            this.Name = "frmListaSimple";
            this.Text = "Estructura de Datos Lista Simple";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNuevoElemento;
        private System.Windows.Forms.GroupBox gpbEliminarElemento;
        private System.Windows.Forms.GroupBox gpbListado;
    }
}