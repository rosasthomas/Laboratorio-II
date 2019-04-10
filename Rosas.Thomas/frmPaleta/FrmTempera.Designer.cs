namespace frmPaleta
{
    partial class FrmTempera
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
            this.Marca = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.Label();
            this.CboColor = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(7, 20);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(40, 13);
            this.Marca.TabIndex = 0;
            this.Marca.Text = "Marca:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(7, 36);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(273, 20);
            this.TxtMarca.TabIndex = 1;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(7, 73);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(34, 13);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color:";
            // 
            // CboColor
            // 
            this.CboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboColor.FormattingEnabled = true;
            this.CboColor.Location = new System.Drawing.Point(7, 89);
            this.CboColor.Name = "CboColor";
            this.CboColor.Size = new System.Drawing.Size(271, 21);
            this.CboColor.TabIndex = 3;
            this.CboColor.SelectedIndexChanged += new System.EventHandler(this.CboColor_SelectedIndexChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(4, 127);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(52, 13);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Text = "Cantidad:";
            this.Cantidad.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(7, 143);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(271, 20);
            this.TxtCantidad.TabIndex = 5;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(7, 198);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(135, 31);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(148, 198);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 31);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmTempera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 240);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.CboColor);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.Marca);
            this.Name = "FrmTempera";
            this.Text = "FrmTempera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox CboColor;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}