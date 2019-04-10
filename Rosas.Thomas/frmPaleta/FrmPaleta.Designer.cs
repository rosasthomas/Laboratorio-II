namespace frmPaleta
{
    partial class FrmPaleta
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
            this.LstLista = new System.Windows.Forms.ListBox();
            this.BtnMas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstLista
            // 
            this.LstLista.FormattingEnabled = true;
            this.LstLista.Location = new System.Drawing.Point(8, 12);
            this.LstLista.Name = "LstLista";
            this.LstLista.Size = new System.Drawing.Size(212, 316);
            this.LstLista.TabIndex = 0;
            // 
            // BtnMas
            // 
            this.BtnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnMas.Location = new System.Drawing.Point(8, 334);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(212, 44);
            this.BtnMas.TabIndex = 1;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 387);
            this.Controls.Add(this.BtnMas);
            this.Controls.Add(this.LstLista);
            this.Name = "FrmPaleta";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstLista;
        private System.Windows.Forms.Button BtnMas;
    }
}

