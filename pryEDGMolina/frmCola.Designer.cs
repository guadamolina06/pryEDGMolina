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
            this.SuspendLayout();
            // 
            // gbxNuevoElemo
            // 
            this.gbxNuevoElemo.Location = new System.Drawing.Point(218, 12);
            this.gbxNuevoElemo.Name = "gbxNuevoElemo";
            this.gbxNuevoElemo.Size = new System.Drawing.Size(194, 191);
            this.gbxNuevoElemo.TabIndex = 0;
            this.gbxNuevoElemo.TabStop = false;
            this.gbxNuevoElemo.Text = "Nuevo Elemento";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.gbxNuevoElemo);
            this.Name = "frmCola";
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNuevoElemo;
    }
}