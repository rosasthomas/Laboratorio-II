namespace VistaForm
{
    partial class FormDT
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxApellido = new System.Windows.Forms.TextBox();
            this.nUDEdad = new System.Windows.Forms.NumericUpDown();
            this.nUDDni = new System.Windows.Forms.NumericUpDown();
            this.nUDExp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDExp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(97, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(97, 103);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(97, 143);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(97, 183);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(62, 13);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Experiencia";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(100, 247);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 23);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(225, 247);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(84, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "&Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(189, 18);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(120, 20);
            this.txtbxNombre.TabIndex = 7;
            // 
            // txtbxApellido
            // 
            this.txtbxApellido.Location = new System.Drawing.Point(189, 58);
            this.txtbxApellido.Name = "txtbxApellido";
            this.txtbxApellido.Size = new System.Drawing.Size(120, 20);
            this.txtbxApellido.TabIndex = 8;
            // 
            // nUDEdad
            // 
            this.nUDEdad.Location = new System.Drawing.Point(189, 101);
            this.nUDEdad.Name = "nUDEdad";
            this.nUDEdad.Size = new System.Drawing.Size(120, 20);
            this.nUDEdad.TabIndex = 9;
            // 
            // nUDDni
            // 
            this.nUDDni.Location = new System.Drawing.Point(189, 141);
            this.nUDDni.Name = "nUDDni";
            this.nUDDni.Size = new System.Drawing.Size(120, 20);
            this.nUDDni.TabIndex = 10;
            // 
            // nUDExp
            // 
            this.nUDExp.Location = new System.Drawing.Point(189, 181);
            this.nUDExp.Name = "nUDExp";
            this.nUDExp.Size = new System.Drawing.Size(120, 20);
            this.nUDExp.TabIndex = 11;
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 305);
            this.Controls.Add(this.nUDExp);
            this.Controls.Add(this.nUDDni);
            this.Controls.Add(this.nUDEdad);
            this.Controls.Add(this.txtbxApellido);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormDT";
            this.Text = "Form DT";
            ((System.ComponentModel.ISupportInitialize)(this.nUDEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxApellido;
        private System.Windows.Forms.NumericUpDown nUDEdad;
        private System.Windows.Forms.NumericUpDown nUDDni;
        private System.Windows.Forms.NumericUpDown nUDExp;
    }
}

