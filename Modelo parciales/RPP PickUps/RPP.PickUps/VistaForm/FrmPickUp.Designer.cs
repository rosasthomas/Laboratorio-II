namespace VistaForm
{
    partial class FrmPickUp
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtbxPatente = new System.Windows.Forms.TextBox();
            this.txtbxModelo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(12, 9);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 72);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtbxPatente
            // 
            this.txtbxPatente.Location = new System.Drawing.Point(12, 34);
            this.txtbxPatente.Name = "txtbxPatente";
            this.txtbxPatente.Size = new System.Drawing.Size(172, 20);
            this.txtbxPatente.TabIndex = 2;
            // 
            // txtbxModelo
            // 
            this.txtbxModelo.Location = new System.Drawing.Point(12, 97);
            this.txtbxModelo.Name = "txtbxModelo";
            this.txtbxModelo.Size = new System.Drawing.Size(169, 20);
            this.txtbxModelo.TabIndex = 3;
            this.txtbxModelo.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 132);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(108, 31);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 174);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtbxModelo);
            this.Controls.Add(this.txtbxPatente);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPatente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPickUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear PickUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtbxPatente;
        private System.Windows.Forms.TextBox txtbxModelo;
        private System.Windows.Forms.Button btnCrear;
    }
}

