namespace FrmTest.clase20
{
    partial class FrmTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnBoton = new System.Windows.Forms.Button();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.TxtCuadroTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBoton
            // 
            this.BtnBoton.Location = new System.Drawing.Point(12, 124);
            this.BtnBoton.Name = "BtnBoton";
            this.BtnBoton.Size = new System.Drawing.Size(117, 33);
            this.BtnBoton.TabIndex = 0;
            this.BtnBoton.Text = "button1";
            this.BtnBoton.UseVisualStyleBackColor = true;
            this.BtnBoton.Click += new System.EventHandler(this.BtnBoton_Click);
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Location = new System.Drawing.Point(23, 9);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(35, 13);
            this.LblEtiqueta.TabIndex = 1;
            this.LblEtiqueta.Text = "label1";
            // 
            // TxtCuadroTexto
            // 
            this.TxtCuadroTexto.Location = new System.Drawing.Point(12, 49);
            this.TxtCuadroTexto.Name = "TxtCuadroTexto";
            this.TxtCuadroTexto.Size = new System.Drawing.Size(104, 20);
            this.TxtCuadroTexto.TabIndex = 2;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtCuadroTexto);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.BtnBoton);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.Click += new System.EventHandler(this.FrmTest_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBoton;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.TextBox TxtCuadroTexto;
    }
}

