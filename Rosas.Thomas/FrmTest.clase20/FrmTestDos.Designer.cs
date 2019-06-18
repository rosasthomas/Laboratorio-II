namespace FrmTest.clase20
{
    partial class FrmTestDos
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
            this.BtnBoton1 = new System.Windows.Forms.Button();
            this.BtnBoton2 = new System.Windows.Forms.Button();
            this.BtnBoton3 = new System.Windows.Forms.Button();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBoton1
            // 
            this.BtnBoton1.Location = new System.Drawing.Point(336, 24);
            this.BtnBoton1.Name = "BtnBoton1";
            this.BtnBoton1.Size = new System.Drawing.Size(72, 40);
            this.BtnBoton1.TabIndex = 0;
            this.BtnBoton1.Text = "button1";
            this.BtnBoton1.UseVisualStyleBackColor = true;
            // 
            // BtnBoton2
            // 
            this.BtnBoton2.Location = new System.Drawing.Point(335, 92);
            this.BtnBoton2.Name = "BtnBoton2";
            this.BtnBoton2.Size = new System.Drawing.Size(73, 37);
            this.BtnBoton2.TabIndex = 1;
            this.BtnBoton2.Text = "button2";
            this.BtnBoton2.UseVisualStyleBackColor = true;
            // 
            // BtnBoton3
            // 
            this.BtnBoton3.Location = new System.Drawing.Point(334, 155);
            this.BtnBoton3.Name = "BtnBoton3";
            this.BtnBoton3.Size = new System.Drawing.Size(73, 38);
            this.BtnBoton3.TabIndex = 2;
            this.BtnBoton3.Text = "button3";
            this.BtnBoton3.UseVisualStyleBackColor = true;
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(473, 95);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(93, 33);
            this.BtnOperar.TabIndex = 3;
            this.BtnOperar.Text = "&Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // FrmTestDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.BtnBoton3);
            this.Controls.Add(this.BtnBoton2);
            this.Controls.Add(this.BtnBoton1);
            this.Name = "FrmTestDos";
            this.Text = "FrmTestDos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBoton1;
        private System.Windows.Forms.Button BtnBoton2;
        private System.Windows.Forms.Button BtnBoton3;
        private System.Windows.Forms.Button BtnOperar;
    }
}