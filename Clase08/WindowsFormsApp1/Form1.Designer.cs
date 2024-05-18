namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnPanico = new System.Windows.Forms.Button();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnOtroMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLabel.Location = new System.Drawing.Point(55, 53);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(82, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Mi label humilde";
            this.lblLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPanico
            // 
            this.btnPanico.Location = new System.Drawing.Point(58, 87);
            this.btnPanico.Name = "btnPanico";
            this.btnPanico.Size = new System.Drawing.Size(111, 54);
            this.btnPanico.TabIndex = 1;
            this.btnPanico.Text = "Boton de panico";
            this.btnPanico.UseVisualStyleBackColor = true;
            this.btnPanico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(58, 174);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(111, 63);
            this.btnMensaje.TabIndex = 2;
            this.btnMensaje.Text = "Mensaje";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnOtroMensaje
            // 
            this.btnOtroMensaje.Location = new System.Drawing.Point(216, 174);
            this.btnOtroMensaje.Name = "btnOtroMensaje";
            this.btnOtroMensaje.Size = new System.Drawing.Size(111, 63);
            this.btnOtroMensaje.TabIndex = 3;
            this.btnOtroMensaje.Text = "Mensaje detallado";
            this.btnOtroMensaje.UseVisualStyleBackColor = true;
            this.btnOtroMensaje.Click += new System.EventHandler(this.btnOtroMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtroMensaje);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.btnPanico);
            this.Controls.Add(this.lblLabel);
            this.Name = "Form1";
            this.Text = "FormularioEze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnPanico;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnOtroMensaje;
    }
}

